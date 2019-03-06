using ImageResize.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageResize
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager; // 테마
        private List<ImageInfo> array = new List<ImageInfo>(); // 원본 이미지 정보
        private string SaveFolder = string.Empty; // 저장폴더
        private int tag = 1; // 리사이즈 옵션

        // 생성자
        public MainForm()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        // 폼 로드 이벤트
        private void MainForm_Load(object sender, EventArgs e)
        {
            optPercent.Checked = true;
            pbLoadImage.Value = 0;

        }

        // 이미지 폴더 열기 버튼 클릭 이벤트
        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            try
            {
                var dlg = new FolderBrowserDialog();
                if (dlg.ShowDialog() != DialogResult.OK) return;
                txtFolerPath.Text = dlg.SelectedPath;
                LoadImages(dlg.SelectedPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // 저장 폴더 열기 버튼 클릭 이벤트
        private void btnSaveFolder_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() != DialogResult.OK) return;
            SaveFolder = dlg.SelectedPath;
            txtSaveFolder.Text = SaveFolder;
        }

        // 변환 버튼 클릭 이벤트
        private void btnRun_Click(object sender, EventArgs e)
        {
            if (array.Count == 0)
            {
                MessageBox.Show("변환 할 대상 이미지가 없습니다.");
                return;
            }
            if (txtSaveFolder.Text == string.Empty)
            {
                MessageBox.Show("저장 폴더를 선택하세요.");
                return;
            }

            // 변환 실행
            RunResize();
        }

        // 옵션 체인지 이벤트
        private void optChanged(object sender, EventArgs e)
        {
            var opt = sender as MaterialRadioButton;
            tag = Convert.ToInt32(opt.Tag);
            switch (tag)
            {
                case 1:
                    // 비율
                    txtPercent.Enabled = true;
                    txtWidth.Enabled = false;
                    txtHeight.Enabled = false;
                    break;
                case 2:
                    // 크기 고정
                    txtPercent.Enabled = false;
                    txtWidth.Enabled = true;
                    txtHeight.Enabled = true;
                    break;
                case 3:
                    // 너비 맞춤
                    txtPercent.Enabled = false;
                    txtWidth.Enabled = true;
                    txtHeight.Enabled = false;
                    break;
                case 4:
                    // 높이 맞춤
                    txtPercent.Enabled = false;
                    txtWidth.Enabled = false;
                    txtHeight.Enabled = true;
                    break;
                default:
                    break;
            }
        }


        // 그리드 인덱스 체인지 이벤트
        private void listResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            var items = listResult.SelectedItems;
        }

        // 이미지 목록 로딩
        private async void LoadImages(string SelectedPath)
        {   
            // UI 초기화
            pbLoadImage.Value = 0;
            listImage.Items.Clear();
            lblCount.Text = $"Searching for images ...";
            await Task.Delay(10);

            // 디렉토리 이미지 파일 검색
            string[] patterns = new[] { "*.jpg", "*.jpeg", "*.jpe", "*.jif", "*.jfif", "*.jfi", "*.webp", "*.gif", "*.png", "*.apng", "*.bmp", "*.dib", "*.tiff", "*.tif", "*.svg", "*.svgz", "*.ico", "*.xbm" };
            //var list = patterns.SelectMany(pattern => Directory.GetFiles(SelectedPath, pattern, SearchOption.AllDirectories)).Distinct().ToList();
            var di = new DirectoryInfo(SelectedPath);
            var list = patterns.SelectMany(pattern => di.GetFiles(pattern, SearchOption.AllDirectories)).Distinct().ToList();
            pbLoadImage.Maximum = list.Count;
            array = new List<ImageInfo>();
            
            for (int i = 0; i < list.Count; i++)
            {
                var g = list[i].FullName;
                var fi = new FileInfo(g);
                //var img = Image.FromFile(g);  // 속도 느림


                var imgInfo = new ImageInfo()
                {
                    Name = fi.Name,
                    Path = g,
                    Size = string.Format("{0:0.0} KB", fi.Length / 1024F),
                    //With = img.Width,
                    //Height = img.Height
                    _FileInfo = list[i],
                };

                using (Stream stream = File.OpenRead(g))
                {
                    using (Image sourceImage = Image.FromStream(stream, false, false))
                    {
                        imgInfo.Width = sourceImage.Width;
                        imgInfo.Height = sourceImage.Height;
                    }
                }

                array.Add(imgInfo);
                var item = new ListViewItem(imgInfo.ToList().ToArray());
                listImage.Items.Add(item);
                await Task.Delay(10);
                pbLoadImage.Value = i + 1;
                lblCount.Text = $"{pbLoadImage.Value} Images";
            }
        }

        // 리사이즈 변환 실행
        private async void RunResize()
        {
            try
            {
                // 변수 초기화
                int idx = 0;
                int w = 0;
                int h = 0;
                Image img = null;

                // Images UI 값 초기화
                pbRun.Value = 0;
                pbRun.Maximum = array.Count;
                lblStatus.Text = string.Empty;
                lblPer.Text = "0%";
                listResult.Items.Clear();
                btnRun.Enabled = false;

                // Result UI 값 초기화
                pbRun.Value = 0;
                lblStatus.Text = string.Empty;
                lblPer.Text = "0%";
                listResult.Items.Clear();
                await Task.Delay(10);

                // 원본 이미지를 옵션에 따라 리사이징
                for (int i = 0; i < array.Count; i++)
                {
                    var g = array[i];
                    using (Stream stream = File.OpenRead(g.Path))
                    {
                        using (Image src = Image.FromStream(stream))
                        {
                            idx++;                            
                            lblStatus.Text = $"[{idx}/{pbRun.Maximum}] {g.Name}";
                            await Task.Delay(10);
                            switch (tag)
                            {
                                case 1:
                                    var percent = Convert.ToInt32(txtPercent.Text.Trim());
                                    w = (int)(g.Width * (percent / 100F));
                                    h = (int)(g.Height * (percent / 100F));
                                    //img = src.Resize(w, h);
                                    img = GetResizeImage(src, w, h);
                                    break;
                                case 2:
                                    w = Convert.ToInt32(txtWidth.Text.Trim());
                                    h = Convert.ToInt32(txtHeight.Text.Trim());
                                    //img = src.Resize(w, h);
                                    img = GetResizeImage(src, w, h);
                                    break;
                                case 3:
                                    w = Convert.ToInt32(txtWidth.Text.Trim());
                                    h = (int)((float)g.Height * ((float)w / (float)g.Width));
                                    //img = src.ResizeW(w);
                                    img = GetResizeImage(src, w, h);
                                    break;
                                case 4:
                                    h = Convert.ToInt32(txtHeight.Text.Trim());
                                    w = (int)((float)g.Width * ((float)h / (float)g.Height));
                                    //img = src.ResizeH(h);
                                    img = GetResizeImage(src, w, h);
                                    break;
                            }

                            // 확장자에 따른 이미지 포맷 결정 후 저장
                            //var path = txtSaveFolder.Text + "\\" + g.Name;
                            // 선택된 폴더 하위로 원본폴더경로 추가  
                            var path = txtSaveFolder.Text + g.Path.Substring(2);
                            var di = txtSaveFolder.Text + g._FileInfo.DirectoryName.Substring(2);
                            
                            Directory.CreateDirectory(di);                           
                            
                            var tmp = g.Name.Split('.');
                            var format = tmp[tmp.Length - 1];
                            switch (format.ToLower())
                            {
                                case "jpg":
                                case "jpeg":
                                    img.Save(path, ImageFormat.Jpeg);
                                    break;
                                case "png":
                                    img.Save(path, ImageFormat.Png);
                                    break;
                                case "bmp":
                                    img.Save(path, ImageFormat.Bmp);
                                    break;
                                case "tiff":
                                    img.Save(path, ImageFormat.Tiff);
                                    break;
                                default:
                                    img.Save(path);
                                    break;
                            }
                            

                            // UI 표현
                            var fi = new FileInfo(path);
                            var imgInfo = new ImageInfo()
                            {
                                Name = fi.Name,
                                Path = path,
                                Size = string.Format("{0:0.0} KB", fi.Length / 1024F),
                            };
                            using (Stream stream2 = File.OpenRead(path))
                            {
                                using (Image sourceImage = Image.FromStream(stream2, false, false))
                                {
                                    imgInfo.Width = sourceImage.Width;
                                    imgInfo.Height = sourceImage.Height;
                                }
                            }
                            var item = new ListViewItem(imgInfo.ToList().ToArray());
                            listResult.Items.Add(item);
                        }
                    }
                    pbRun.Value = idx;
                    pbRun.Refresh();
                    lblPer.Text = string.Format("{0:0}%", (idx / (pbRun.Maximum / 100F)));
                    await Task.Delay(10);
                }
                btnRun.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                btnRun.Enabled = true;
            }
        }


        // 이미지 리사이즈 변환 함수
        private Image GetResizeImage(Image orig, int w, int h, InterpolationMode mode = InterpolationMode.Default)
        {
            // 보간법을 쓰지 않을 경우
            //Bitmap bmp1 = new Bitmap(orig, new Size(w, h));
            //return bmp1;

            // 보간법을 쓸 경우
            Bitmap bmp = new Bitmap(w, h);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = mode;
                g.DrawImage(orig, new Rectangle(0, 0, w, h));
            }
            return bmp;
        }
    }
}
