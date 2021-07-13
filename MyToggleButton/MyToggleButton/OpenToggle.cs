using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace MyToggleButton
{

    /// <summary>
    /// OpenToggle adı altında yeni bir sınıf oluşturduk.
    /// Control sınıfının işlevsel özelliklerini kullanmak adına sınıfımıza aktarım yaptık.
    /// </summary>
    public class OpenToggle : Control
    {

        /// <summary>
        /// 1-) float tipinde ve diameter adında bir private metot tanımladık.
        /// 2-) MyRectangle sınıfımızdan rect adında bir parametre çektik.
        /// 3-) RectangleF yapısından circle adında bir parametre çektik.
        /// 4-) bool tipinde isON adında bir metot oluşturduk.
        /// 5-) float tipinde artis adında bir metot oluşturduk.
        /// 6-) Color yapısından bir borderColor adında bir metot oluşturduk.
        /// 7-) bool tipinde textEnabled adında bir metot oluşturduk.
        /// 8-) string tipinde OnTex adında bir metot oluşturduk.
        /// 9-) string tipinde OffTex adında bir metot oluşturduk.
        /// 10-) Color yapısından OnCol adında bir metot oluşturduk.
        /// 11-) Color yapısından OffCol adında bir metot oluşturduk.
        /// 12-) painTicker adında bir Timer oluşturduk.
        /// 13-) Value özelliğimiz değiştiğinde Value Changed olayımız tetiklenmesi için bu metotu yazdık.
        /// </summary>

        private float diameter;
        private MyRectangle rect;
        private RectangleF circle;
        private bool isON;
        private float artis;
        private Color borderColor;
        private bool textEnabled;
        private string OnTex= "";
        private string OffTex = "";
        private Color OnCol;
        private Color OffCol;
        private Timer painTicker = new Timer();
        public event SliderChangedEventHandler SliderValueChanged;
        



        /// <summary>
        /// OpenToggle adında; public türünde bir yapıcı metot oluşturduk.
        /// </summary>
        public OpenToggle()
        {
            /// <summary>
            /// 1-) Cursorumuzun el işareti şeklini almasını sağladık.
            /// 2-) Yazdığımız Doublebuffered kodu sayesinde formumuz varsayılan çift arabelleğe alınır ve titreşimsiz grafik işleme sağlanır.
            /// 3-) artis değişkenine float tipinde 4 sayısını atadık.
            /// 4-) diameter değişkenine float tipinde 30 değerini atadık.
            /// 5-) bool tüündeki textEnabled değişkenine true değerini atadık.
            /// 6-) MyRectangle class'ı çağırıp işlem yaptırıp rect değişkenine atadık.
            /// 7-) RectangleF nesnesi ile circle değişkeninin parametre girdisini atadık.
            /// 8-) bool türündeki isON değişkenini false olarak atadık.
            /// 9-) borderColor değişkenini Color yapısıyla LİghtGray rengi atadık.
            /// 10-) painTicker.Tick'i temsilciye atanan yöntemi işleyicisiyle bağladık.
            /// 11-) Tİmer türünden olaylar arasındaki süreyi ayarlamış olduk.
            /// 12-) OnCol rengini RGB türünden belirledik.
            /// 13-) OffCol rengini Dark Gray olarak belirledik.
            /// 14-) ForeColor rengini White olarak belirledik.
            /// 15-) OnTex stringini "ON" olarak yazdırdık.
            /// 16-) OffTex stringini "OFF" olarak yazdırdık.
            /// </summary>

            this.Cursor = Cursors.Hand;
            this.DoubleBuffered = true;
            this.artis = 4f;
            this.diameter = 30f;
            this.textEnabled = true;
            this.rect = new MyRectangle(2f * this.diameter, this.diameter + 2f, this.diameter / 2f, 1f, 1f);
            this.circle = new RectangleF(1f, 1f, this.diameter, this.diameter);
            this.isON = false;
            this.borderColor = Color.LightGray;
            this.painTicker.Tick += new EventHandler(this.paintTicker_Tick);
            this.painTicker.Interval = 1;
            this.OnCol = Color.FromArgb(94, 148, 255);
            this.OffCol = Color.DarkGray;
            this.ForeColor = Color.White;
            this.OnTex = "ON";
            this.OffTex = "OFF";
           
        }

        /// <summary>
        /// protected tipinde bir override void kullanarak türetilmiş sınıfımıza bir temsilci iliştirmeden olayı işlememizi sağladık.
        /// </summary>
        protected override void OnEnabledChanged(EventArgs e)
        {
            base.Invalidate();
            base.OnEnabledChanged(e);
        }


        /// <summary>
        /// Temsilci yoluyla olay işleyicisini çağırdık. MouseDown olayını oluşturduk.
        /// </summary>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            this.isON = !this.isON;
            this.IsOn = this.isON; 
            base.OnMouseClick(e);
        }


        /// <summary>
        /// Kullanıcının bir resim veya resim dosyasını form üzerine sürükleyebilmesini sağladık. Form her boyandığında görüntünün yeniden boyanması için geçersiz kılınır; aksi takdirde görüntü yalnızca bir sonraki yeniden çizmeye kadar alır.
        /// </summary>
        

        
        protected override void OnPaint(PaintEventArgs e)

        {
            /// <summary>
            /// Graphics sınıfından smoothing mode özellğini kullanrak yüksek kalite görüntü modunu kullanarak iyileştirme yaptık.
            /// </summary>
            e.Graphics.SmoothingMode = (SmoothingMode)SmoothingMode.HighQuality;


            /// <summary>
            /// Eğer override olayı gerçekleşerek geçersiz kılma işlemi oluşursa
            /// </summary>
            if (base.Enabled)
            {

                /// <summary>
                /// Pen sınıfından pen adında bir nesne oluşturduk.
                /// using deyiminin içerisinde SolidBrush sınıfını çağırarak brush adında bir nesne ürettik.
                /// Graphics sınıfının FillPath özelliğini kullanarak ekrandaki yolu doldurduk.
                /// Sonrasında using deyiminin içerisinde Pen sınıfını çağırarak ve 2 değerlerini girdik.
                /// Graphics sınıfının FillPath özelliğini kullanarak ekrandaki yolun çizimini yapmayı sağladık..
                /// </summary>
                Pen pen;
                using(SolidBrush brush = new SolidBrush(this.isON ? this.OnCol : this.OffCol))
                {
                    e.Graphics.FillPath((Brush)brush, this.rect.Path);
                }
                using(pen = new Pen(this.borderColor, 2f))
                {
                    e.Graphics.DrawPath(pen, this.rect.Path);
                }


                /// <summary>
                /// Textimizin yani yazımızın inaktif (devre dışı) veya aktif olması halinde gerçekleştiği durumlarda aşağıdaki olaylar olacaktır.
                /// </summary>
                if (this.textEnabled)
                {

                    /// <summary>
                    /// using yapısını kullanarak font adında yeni bir Font nesnesi atadık ve "Century Gothic" adını verdik. Fontun yazı boyunu ve bold olmasını ayrladık.
                    /// SolidBrush sınıfından yeni bir nesne ürettik ve this anahtar sözcüğüyle forecolor özellğini yazdık.
                    /// float tipinde num2 adında bir değişkene metin için ilk sınırlayıcı dikdörtgeni oluşturmak adına belirtilen boyutlar kullanılarak yazı tipi ve biçimlendirme yönergeleriyle birlikte çizildiğinde verilen metnin (onTex) boyutunu piksel cinsinden sağlar.
                    /// Belirttiğimiz metin dizesini belirtilen konumda font, b, 5, num2 + 1 değerlerini kullanarak çizdireceğiz.
                    /// height  değişkene metin için ilk sınırlayıcı dikdörtgeni oluşturmak adına belirtilen boyutlar kullanılarak yazı tipi ve biçimlendirme yönergeleriyle birlikte çizildiğinde verilen metnin (onTex) boyutunu piksel cinsinden sağlar.
                    /// num2 ye; diameter değerinden height değerini çıkarıp 2'ye bölme işlemi sonucunu atadık.
                    /// Drawstring ifadesini yukardaki OnTex için yapmıştık. Burada da OffTex için yaptık.
                    /// </summary>
                    using (Font font = new Font("Century Gothic", (8.2f * this.diameter) / 30f, (FontStyle)FontStyle.Bold))
                    {
                        SolidBrush b = new SolidBrush(this.ForeColor);
                        int height = TextRenderer.MeasureText(this.OnTex, font).Height;
                        float num2 = (this.diameter - height) / 2f;
                        e.Graphics.DrawString(this.OnTex, font, b, 5f, num2 + 1f);
                        height = TextRenderer.MeasureText(this.OffTex, font).Height;
                        num2 = (this.diameter - height) / 2f;
                        e.Graphics.DrawString(this.OffTex, font, b, this.diameter + 2f, num2 + 1f);
                    }

                    /// <summary>
                    /// using söz dizimini kullanarak SolidBrush sınıfından brush2 nesnesini türetip ona; ExtenssionMethod classımızdan bir renk kodu atıyoruz.
                    /// Graphics sınıfımızdaki FillEllipse özelliğini kullanarak ve parantez içindeki değerlerimizi alarak elipsimizin içini dolduruyoruz.
                    /// </summary>
                    using(SolidBrush brush2 = new SolidBrush("#FFFFFF".FromHex()))
                    {
                        e.Graphics.FillEllipse((Brush)brush2,this.circle);
                    }

                    /// <summary>
                    /// using söz dizisiyle pen nesnesinin rengini light gray ve büyüklüğünü 1.2 olarak ayarladık.
                    /// Elipsimizi çizdirmek için kullanıyoruz.
                    /// </summary>
                    using(pen = new Pen(Color.LightGray, 1.2f))
                    {
                        e.Graphics.DrawEllipse(pen, this.circle);
                    }
                }


                /// <summary>
                /// Diğer durumlarda;
                /// </summary>
                else
                {
                    /// <summary>
                    /// using söz dizimiyle brush3 adında yeni bir nesne oluşturup ExtenssionMethod sınıfımızdaki renk kodunu veriyoruz.
                    /// brush4 için de aynı şeyi yapıyoruz.
                    /// brush3 ile yolu dolduruyoruz.
                    /// brush4 ile elipsimizi dolduruyoruz.
                    /// DarkGray ile elipsimizi çiziyoruz.
                    /// </summary>
                    using (SolidBrush brush3 = new SolidBrush("#FFFFFF".FromHex()))
                    {
                        using (SolidBrush brush4 = new SolidBrush("#FFFFFF".FromHex()))
                        {
                            e.Graphics.FillPath((Brush)brush3, this.rect.Path);
                            e.Graphics.FillEllipse((Brush)brush4, this.circle);
                            e.Graphics.DrawEllipse(Pens.DarkGray, this.circle);
                        }
                    }
                }
            }
            base.OnPaint(e);
        }

        /// <summary>
        /// Denetim yeniden boyutlandırıldığında gerçekleşek protectet bir OnResize metodu tanımlıyoruz.
        /// </summary>
        protected override void OnResize(EventArgs e)
        {
            /// <summary>
            /// Ana size değeri height değerinin 2 eksiğinin 2 katı olarak tanımlıyoruz.
            /// diameter değerini ana size değerinin yarısı olarak tanımlıyoruz.
            /// artis değerini diameter değerinin 4 katı ve 30 katı şeklinde tanımlıyoruz.
            /// MyRectangle sınıfımızdan rect değerini oluşturuyoruz
            /// circle ımızı RectangleF yapısında isOn, width, diameter değerleriyle kuruyoruz.
            /// </summary>
            base.Width = (base.Height - 2) * 2;
            this.diameter = base.Width / 2;
            this.artis = (4f * this.diameter) * 30f;
            this.rect = new MyRectangle(2f * this.diameter, this.diameter + 2f, this.diameter / 2f, 1f, 1f);
            this.circle = new RectangleF(!this.isON ? 1f : ((base.Width - this.diameter) - 1f), 1f, this.diameter, this.diameter);
            base.OnResize(e);
        }


        /// <summary>
        /// painTicker_Tick void metodumuzu oluşturduk.
        /// </summary>

        private void paintTicker_Tick(object sender,EventArgs e)
        {
            /// <summary>
            /// float tipindeki x'i this anahtar sözcüğüyle circle.x olarak atadık.
            /// </summary>
            float x = this.circle.X;

            /// <summary>
            /// Eğer isOn olursa;
            /// </summary>
            if (this.isON)
            {
                /// <summary>
                /// eğer x + artis değeri width ve diameter değerlerinin toplamının bir eksiğinden küçük veya eşit olursa 
                /// </summary>
                if ((x + this.artis) <= (base.Width - this.diameter) - 1f)
                {

                    /// <summary>
                    /// x'i arttırarak artis değerine eşitle.
                    /// circle değeri RectangleF yapısıyla parantez içindeki verilen parametrelere eşit olsun.
                    /// </summary>
                    x += this.artis;
                    this.circle = new RectangleF(x, 1f, this.diameter, this.diameter);
                    base.Invalidate();
                }

                /// <summary>
                /// Diğer durumlarda;
                /// </summary>
                else
                {
                    /// <summary>
                    /// x değeri width'ten diameter değerinin çıkartılıp 1 float azaltılmasına eşit olsun.
                    /// circle'ımız RectangleF yapısıyla oluşturulmuş parametrele eşitlensin.
                    /// </summary>
                    x = (base.Width - this.diameter) - 1f;
                    this.circle = new RectangleF(x, 1f, this.diameter, this.diameter);
                    base.Invalidate();
                    this.painTicker.Stop();
                }
            }


            /// <summary>
            /// x değerinden artis değerinin çıkartılması 1float değerinden büyük veya eşit olursa;
            /// </summary>
            else if ((x - this.artis) >= 1f)
            {

                ///<summary>
                ///x'i azaltarak artis değerine eşitle.
                ///circle'ımız RectangleF yapısıyla verilen parantez içindeki parametrelere eşitlensin.
                /// </summary>
                x -= this.artis;
                this.circle = new RectangleF(x, 1f, this.diameter, this.diameter);
            }

            /// <summary>
            /// Diğer durumda ;
            /// </summary>
            else
            {
                /// <summary>
                /// x değeri 1 floata eşitlensin.
                /// circle'ımız RectangleF yapısıyla verilen parantez içerisindeki parametrele eşit olsun.
                /// </summary>
                x = 1f;
                this.circle = new RectangleF(x, 1f, this.diameter, this.diameter);
                base.Invalidate();
                this.painTicker.Stop();
            }
        }

        /// <summary>
        /// TextEnabled'ı bool türünden metod olarak yazdırdık. Get ve set ettik. Set'te this.Enabled işlemini value değere eşitledik
        /// </summary>
        public bool TextEnabled
        {
            get =>
                this.textEnabled;
            set
            {
                this.textEnabled = value;
                base.Invalidate();
            }
        }


        /// <summary>
        /// IsOn adında bool türünde metot oluşturduk. Get ve Set işlemlerini yaptık.
        /// </summary>
        public bool IsOn
        {
            get =>
                this.isON;
            set
            {
                /// <summary>
                /// isOn değerini valueya eşitledik.
                /// </summary>
                this.painTicker.Stop();
                this.isON = value;
                this.painTicker.Start();

                /// <summary>
                /// eğer SliderValueChanged değeri null'a eşit olmazsa
                /// </summary>
                if(this.SliderValueChanged != null)
                {
                    /// <summary>
                    /// EventArgs.Empty yapısını this anahtar sözcüğüyle kullandık. Verileri olmayan olaylarla brlikte kullanacak değer sağladık.
                    /// </summary>
                    this.SliderValueChanged(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Color sınıfından BorderColor adında bir metot oluşturduk. Get ve set işlemlerini yaptık. Set'de borderColor'u value değerine eşitledik.
        /// </summary>
        public Color BorderColor
        {
            get =>
                this.borderColor;
            set
            {
                this.borderColor = value;
                base.Invalidate();
            }
        }

        /// <summary>
        /// Varsayılan genişliği 60,35 vererek önceki size verisini ezmiş olduk.
        /// </summary>
        protected override Size DefaultSize => new Size(60, 35);


        /// <summary>
        /// Delegate yapısını bellek adresi tutmak için kullandık.
        /// </summary>
        public delegate void SliderChangedEventHandler(object sender, EventArgs e);


        /// <summary>
        /// Düğme açıkken olacak yani OnText yazısını string türünden metot haline getirdik ve get, set işlemlerini yaptık. OnTex değerini value'ya eşitledik.
        /// </summary>
        public string OnText
        {
            get =>
                this.OnTex;
            set
            {
                this.OnTex = value;
                base.Invalidate();
            }
        }

        /// <summary>
        /// Düğme kapalıyken olacak yani OnText yazısını string türünden metot haline getirdik ve get, set işlemlerini yaptık. OffTex değerini value'ya eşitledik.
        /// </summary>
        public string OffText
        {
            get =>
                this.OffTex;
            set
            {
                this.OffTex = value;
                base.Invalidate();
            }
        }

        /// <summary>
        /// Color sınıfını kullanarak düğmemiz açıkken oluşacak rengi metot haline getirerek get ve set ettik. Set'te OnCol değerini value'ya eşitledik.
        /// </summary>
        public Color OnColor
        {
            get =>
                this.OnCol;
            set
            {
                this.OnCol = value;
                base.Invalidate();
            }

        }

        /// <summary>
        /// Color sınıfını kullanarak düğmemiz kapalıyken oluşacak rengi metot haline getirerek get ve set ettik. Set'te OffCol değerini value'ya eşitledik.
        /// </summary>
        public Color OffColor
        {
            get => this.OffCol;
            set
            {
                this.OffCol = value;
                base.Invalidate();
            }
        }

    }
}
