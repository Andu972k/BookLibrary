using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary.Model
{
    public class Bog
    {

        #region InstanceFields

        private string _titel;
        private string _forfatter;
        private int _sidetal;
        private string _isbn13;

        


        #endregion

        #region Properties

        public string Titel
        {
            get { return _titel; }
            set
            {
                CheckTitel(value);
                _titel = value;
            }
        }

        public string Forfatter
        {
            get { return _forfatter; }
            set { _forfatter = value; }
        }

        public int Sidetal
        {
            get { return _sidetal; }
            set
            {
                CheckSidetal(value);
                _sidetal = value;
            }
        }

        public string Isbn13
        {
            get { return _isbn13; }
            set
            {
                CheckIsbn13(value);
                _isbn13 = value;
            }
        }

        #endregion

        #region Constructor

        public Bog()
        {
            
        }

        public Bog(string titel, string forfatter, int sidetal, string isbn13)
        {
            CheckTitel(titel);
            CheckSidetal(sidetal);
            CheckIsbn13(isbn13);
            _titel = titel;
            _forfatter = forfatter;
            _sidetal = sidetal;
            _isbn13 = isbn13;

        }


        #endregion

        #region Methods

        public override string ToString()
        {
            return $"{nameof(Titel)}: {Titel}, {nameof(Forfatter)}: {Forfatter}, {nameof(Sidetal)}: {Sidetal}, {nameof(Isbn13)}: {Isbn13}";
        }

        #endregion

        #region HelpMethods

        private void CheckTitel(string titel)
        {
            if (titel.Length < 2)
            {
                throw new ArgumentException("Titel skal være minimum 2 tegn");
            }

        }

        private void CheckSidetal(int sidetal)
        {
            if (sidetal < 10 || sidetal > 1000)
            {
                throw new ArgumentOutOfRangeException("sidetal", sidetal, "Antal sider skal være mellem 10 og 1000");
            }
        }

        private void CheckIsbn13(string isbn13)
        {
            if (isbn13.Length != 13)
            {
                throw new ArgumentException("Isbn13 skal være på 13 tegn");
            }
        }

        #endregion

        

    }
}
