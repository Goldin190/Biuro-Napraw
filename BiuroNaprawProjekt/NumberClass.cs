using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiuroNaprawProjekt
{
    public class NumberClass
    {
        public List<decimal> stacyjna;
        public decimal koncetntrator;
        public decimal numer;
        public List<decimal> liniowa;
        public int jwID;
        public string nazwa;
        public string adres;
        public decimal ograniczenia;
        public string trasa;
        public string uwagi;

        public NumberClass()
        {
            this.liniowa = new List<decimal>(2) { 0,0 };
            this.stacyjna = new List<decimal>(3) { 0,0,0};
        }

        public void PopulateFromList(List<string> row)
        {            
            this.numer = decimal.Parse(row[0]);
            this.stacyjna = ConvertStringToDecimalList(row[1], '-');
            this.koncetntrator = this.stacyjna[0];
            this.liniowa = ConvertStringToDecimalList(row[3], '-');
            this.jwID = int.Parse(row[4]);
            this.nazwa = row[5];
            this.adres = row[6];
            this.ograniczenia = decimal.Parse(row[7]);
            this.trasa = row[8];
            this.uwagi = row[9];
        }
        public void PopulateFromList(List<string> row, int jwID)
        {
            this.numer = decimal.Parse(row[0]);
            this.stacyjna = ConvertStringToDecimalList(row[1], '-');
            this.koncetntrator = this.stacyjna[0];
            this.liniowa = ConvertStringToDecimalList(row[3], '-');
            this.jwID = jwID;
            this.nazwa = row[5];
            this.adres = row[6];
            this.ograniczenia = decimal.Parse(row[7]);
            this.trasa = row[8];
            this.uwagi = row[9];
        }
        public List<decimal> ConvertStringToDecimalList(string s,char sep)
        {
            List<decimal> returnList = new List<decimal>();
            int len = s.Split(sep).Length;
            for(int i = 0; i < len; i++)
            {
                returnList.Add(decimal.Parse(s.Split(sep)[i]));
            }
            return returnList;
        }

        public string ConverStacyjnaToString()
        {
            return this.stacyjna[0].ToString() + "-" + this.stacyjna[1].ToString() + "-" + this.stacyjna[2].ToString();
        }
        
        public string ConverLiniowaToString()
        {
            return this.liniowa[0].ToString() + "-" + this.liniowa[1].ToString();
        }
        
        public List<string> ToList()
        {
            List<string> ObjectToString = new List<string>();
            ObjectToString.Add(numer.ToString());
            ObjectToString.Add(ConverStacyjnaToString());
            ObjectToString.Add(koncetntrator.ToString());
            ObjectToString.Add(ConverLiniowaToString());
            ObjectToString.Add(jwID.ToString());
            ObjectToString.Add(nazwa);
            ObjectToString.Add(adres);
            ObjectToString.Add(ograniczenia.ToString());
            ObjectToString.Add(trasa);
            ObjectToString.Add(uwagi);
            return ObjectToString;
        }
        public List<string> ToList(string jwname)
        {
            List<string> ObjectToString = new List<string>();
            ObjectToString.Add(numer.ToString());
            ObjectToString.Add(ConverStacyjnaToString());
            ObjectToString.Add(koncetntrator.ToString());
            ObjectToString.Add(ConverLiniowaToString());
            ObjectToString.Add(jwname);
            ObjectToString.Add(nazwa);
            ObjectToString.Add(adres);
            ObjectToString.Add(ograniczenia.ToString());
            ObjectToString.Add(trasa);
            ObjectToString.Add(uwagi);
            return ObjectToString;
        }
    }
}
