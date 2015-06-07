using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Loto.Models.DataAccess;
using Loto.Models;
using HtmlAgilityPack;
using System.Text;

namespace Loto.Models
{
    public class ResultatModel
    {
        public List<nouveau_loto> ResultatTirage = new List<nouveau_loto>();
        public List<nouveau_loto> ResultatProba = new List<nouveau_loto>();
        public HtmlNodeCollection temp;

        public void ListResultatLoto()
        {
            using (LotoEntities2 context = new LotoEntities2())
            {
                var reqLastLoto = (from c in context.nouveau_loto
                                   orderby c.date_de_tirage descending
                                   select c).Take(10).ToList();

                foreach (var item in reqLastLoto)
                {
                    ResultatTirage.Add(item);
                }
            }
        }

        public void ListResultatProbablite()
        {
            using (LotoEntities2 context = new LotoEntities2())
            {
                var reqLastLoto = (from c in context.nouveau_loto
                                   orderby c.boule_1 descending
                                   select c).Take(10);

                foreach (var item in reqLastLoto)
                {
                    ResultatProba.Add(item);
                }
            }
        }

        public void ResearchResultLoto()
        {

            HtmlWeb web = new HtmlWeb();
            web.AutoDetectEncoding = false;
            web.OverrideEncoding = System.Text.Encoding.GetEncoding("iso-8859-1");
            HtmlDocument doc = web.Load(Loto.Models.Constant.URLSITELOTO);

            //Date de tirage
            var dateTirage = doc.DocumentNode.SelectNodes("//*[contains(@class,'"+Loto.Models.Constant.DATETIRAGE+"')]").Nodes().First();
            string temp1 = dateTirage.InnerText;

            //Boule
            foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//*[contains(@class,'"+Loto.Models.Constant.LOTOBOULE+"')]"))
            {
                string value = node.InnerText;
                // etc...
            }
            //Boule complémentaire
            var bouleComplementaire = doc.DocumentNode.SelectNodes("//*[contains(@class,'" + Loto.Models.Constant.LOTOBOULEC + "')]").Nodes().First();
            string temp2 = bouleComplementaire.InnerText;

            //Numéro joker plus
            var numeroJokerPlus = doc.DocumentNode.SelectNodes("//*[contains(@class,'" + Loto.Models.Constant.NUMEROJOKERPLUS + "')]").Nodes().First();
            string temp3 = numeroJokerPlus.InnerText;

            //Comptablise le nombre de colonne de la premiére ligne afin de savoir si il y a un gagnant du gros lot
            var countNbrColonnePremierGagnant =  doc.DocumentNode.SelectNodes("//tr[1]//td").Count();

            //table contenant les gagnants et les sommes des vainqueurs
            var GagnantTable = doc.DocumentNode.SelectNodes("//*[contains(@class,'" + Loto.Models.Constant.RESULTATGAGNANT + "')]");

            List <string> td2ArgentGagne = new List<string>();
            foreach (HtmlNode col in doc.DocumentNode.SelectNodes("//*[contains(@class,'" + Loto.Models.Constant.RESULTATGAGNANT + "')]//td[2]"))
            {
               td2ArgentGagne.Add( HtmlEntity.DeEntitize(col.InnerText));
            }

            List<string> td3NbrGagnant = new List<string>();
            foreach (HtmlNode col in doc.DocumentNode.SelectNodes("//*[contains(@class,'" + Loto.Models.Constant.RESULTATGAGNANT + "')]//td[3]"))
            {
                td3NbrGagnant.Add(HtmlEntity.DeEntitize(col.InnerText));
            }

            int rez = td2ArgentGagne.Count();
            int rez2 = td3NbrGagnant.Count();
            //foreach (HtmlNode row in GagnantTable.Nodes())
            //{          
                //foreach (HtmlNode col in row.SelectNodes("//td[2]"))
                //{
                //    string temp4 = HtmlEntity.DeEntitize(col.InnerText);
                //}

                //foreach (HtmlNode col in row.SelectNodes("//td[3]"))
                //{
                //    string temp4 = HtmlEntity.DeEntitize(col.InnerText);
                //}
            
            //}
        }
    }
}