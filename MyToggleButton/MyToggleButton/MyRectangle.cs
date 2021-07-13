using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;



namespace MyToggleButton
{

    /// <summary>
    /// MyRectangle adında İnternal biçiminde bir class oluşturduk ve private türünden çeşitli metodlar oluşturduk.
    /// 1-) Point yapısında location adında private bir metod oluşturduk.
    /// 2-) Float tipinde radius adında private bir metod oluşturduk.
    /// 3-) GraphichsPath yapısından yararlanarak grPath adında private metod oluşturduk.
    /// 4-) Float tipinde x adında private bir metod oluşturduk.
    /// 5-) Float tipinde y adında private bir metod oluşturduk.
    /// 6-) Float tipinde width adında private bir metod oluşturduk.
    /// 7-) Float tipinde height adında private bir metod oluşturduk.
    /// </summary>
    internal class MyRectangle 
    {
        private Point location;
        private float radius;
        private GraphicsPath grPath;
        private float x;
        private float y;
        private float width;
        private float height;
        
        


        public MyRectangle() { }

      /// <summary>
      /// Dikdörtgenimizi oluşturacak width, height, x, y ve radiusu MyRectangle metodunun içine yazdık. x ve y değişkenlerine sıfır atadık
      /// </summary>
     
        public MyRectangle(float width, float height, float radius, float x = 0f, float y = 0f)
        {
            /// <summary>
            /// 1-) Location parametresinin Point değerlerini 0'a eşitledik.
            /// 2-) This anahtar sözcüğü ile yapıcı metoda parametre olarak gönderilen radiusu; sınıfın üye elemanına aktardık.
            /// 3-) This anahtar sözcüğü ile yapıcı metoda parametre olarak gönderilen x'i; sınıfın üye elemanına aktardık.
            /// 4-) This anahtar sözcüğü ile yapıcı metoda parametre olarak gönderilen y'yi; sınıfın üye elemanına aktardık.
            /// 5-) This anahtar sözcüğü ile yapıcı metoda parametre olarak gönderilen width değerini; sınıfın üye elemanına aktardık.
            /// 6-) This anahtar sözcüğü ile yapıcı metoda parametre olarak gönderilen height değerini; sınıfın üye elemanına aktardık.
            /// 7-) Yeni bir GraphicsPath sınfını çağırdık ve this anahtar sözcüğü ile grPath değişkenine eşitledik.
            /// </summary> 
            this.location = new Point(0, 0);
            this.radius = radius;
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.grPath = new GraphicsPath();

            /// <summary>
            /// Eğer radius değeri 0'dan küçük veya eşit ise;
            /// </summary>
           
            if(radius <= 0f)
            {
                /// <summary>
                /// RectangleF yapısı kullanrak 4 parametreli değerleri belirttik ve yolumuza x, y, width ve height parametreleriyle bir dikdörtgen çizdirdik.
                /// </summary>
                this.grPath.AddRectangle(new RectangleF(x, y, width, height));
            }

            /// <summary>
            /// Eğer radius değeri 0 dan küçük veya eşit değil ise;
            /// </summary>

            else
            {
                /// <suumary>
                /// Dikdörtgenimizin RectangleF yapısı altında ef, ef2, ef3 ve ef4 değişkenlerinin alacakları değerleri x, y, radius ve width parametrelerinin işlemleriyle eşitledik.
                /// </suumary>


                RectangleF ef = new RectangleF(x, y, 2f * radius, 2f * radius);
                RectangleF ef2 = new RectangleF((width - (2f * radius)) - 1f, x, 2f * radius, 2f * radius);
                RectangleF ef3 = new RectangleF(x, (height - (2f * radius)) - 1f, 2f * radius, 2f * radius);
                RectangleF ef4 = new RectangleF((width - (2f * radius)) - 1f,
                    (height - (2f * radius)) - 1f, 2f * radius, 2f * radius);


                /// <summary>
                /// Oluşturduğumuz 4 tane ef'yi de ekleyerek; AddArc yöntemiyle yeni bir yol oluşturduk ve şeklimizi elips yay eklemiş olduk.
                /// </summary>

                this.grPath.AddArc(ef, 180f, 90f);
                this.grPath.AddArc(ef2, 270f, 90f);
                this.grPath.AddArc(ef4, 0f, 90f);
                this.grPath.AddArc(ef3, 90f, 90f);
                this.grPath.CloseAllFigures();
            }
        }

        /// <summary>
        ///  Metodumuzda this anahtar sözüğüyle grPath; Path değerine atanmış oldu ve dönüştü.
        /// </summary>
        public GraphicsPath Path =>
            this.grPath;

        /// <summary>
        /// Metodumuzda RectangleF yapısıyla Rect adı altında new RectangleF değerleri this anahtar sözcüğü yardımıyla x, y, width ve height parametrelerinden aktarıldı
        /// </summary>
        public RectangleF Rect =>
            new RectangleF(this.x, this.y, this.width, this.height);



        /// <summary>
        /// float tipinde Radius değeri this anahtar sözcüğüyle "radius"'dan get edildi ve set yapısında value değerine eşitlendi.
        /// </summary>
        public float Radius
        {

            get =>
                this.radius;

            set =>
                this.radius = value;
        }



    }
}
