using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Loto.Models.DataAccess;
using Loto.Models;

namespace Loto.Models
{
    public class ResultatModel
    {
    
        public List<lto_tirage> ResultatTirage= new List<lto_tirage>();
        public List<lto_probabilite> ResultatProba = new List<lto_probabilite>();

        public void ListResultatLoto()
        {
            using (lotoEntities context = new lotoEntities())
            {
                var reqLastLoto = (from c in context.lto_tirage
                                   orderby c.tir_dateTirage descending
                                   select c).Take(10).ToList();

                foreach (var item in reqLastLoto)
                {
                    ResultatTirage.Add(item);
                }
            }
        }

        public void ListResultatProbablite()
        {
            using (lotoEntities context = new lotoEntities())
            {
                var reqLastLoto = (from c in context.lto_probabilite
                                   orderby c.pro_id descending
                                   select c).Take(10);

                foreach (var item in reqLastLoto)
                {
                    ResultatProba.Add(item);
                }
            }
        }
    }
}