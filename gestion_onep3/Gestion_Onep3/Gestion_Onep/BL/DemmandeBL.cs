using Gestion_Onep.MODEL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Onep.BL
{
    public class DemmandeBL
    {
        private static DemmandeBL _Instance;
        public static DemmandeBL Instance
        {
            get
            { 
                if (_Instance == null)
                    _Instance = new DemmandeBL();
                return _Instance;
            }
        }

        //public void cleardefault()
        //{
        //    try
        //    {
        //        gestion_agentEntities1 context = new gestion_agentEntities1();
        //        context.Demande.tolist().foreach (x => x.defaut = false);
        //        context.savechanges();
        //    }
        //    catch (exception)
        //    {
        //        throw;
        //    }
        //}
        public void UpdateDemande(Demande newDemande)
        {
            try
            {
                gestion_agentEntities1 context = new gestion_agentEntities1();
                Demande oldDemande = context.Demande.FirstOrDefault(o => o.id == newDemande.id);
                context.Entry(oldDemande).CurrentValues.SetValues(newDemande);
                context.SaveChanges();
                //MessageBox.Show("Modification : Demande a  été modifié avec succès!");
            }
            catch (Exception)
            {
                throw;
                //MessageBox.Show("Erreur : Demande n'a pas été modifié !" + ex.Message);
            }
        }

        public Demande GetDemandeById(int id)
        {
            try
            {
                gestion_agentEntities1 context = new gestion_agentEntities1();
                Demande t = context.Demande.Where(e => e.id == id).FirstOrDefault<Demande>();
                return t;
            }
            catch (Exception)
            {

                throw;
            }

        }
        /// <summary>
        /// Get unit of product by name
        /// </summary>
        /// <param name="name">unit name</param>
        /// <returns></returns>
        public Demande GetDemandeBLByName(string name)
        {
            try
            {
                gestion_agentEntities1 context = new gestion_agentEntities1();
                Demande t = context.Demande.Where(e => e.Precisions == name).FirstOrDefault<Demande>();
                return t;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public List<Demande> GetDemandeBLByType(string typeId)
        {
            try
            {
                gestion_agentEntities1 context = new gestion_agentEntities1();
                return context.Demande.Where(e => e.type == typeId).ToList();
            }
            catch (Exception)
            {

                throw;
            }

        }


        public void AddDemande(Demande t)
        {
            try
            {
                gestion_agentEntities1 context = new gestion_agentEntities1();
                context.Demande.Add(t);
                context.SaveChanges();
                //   MessageBox.Show("Insertion : Demande a été ajouté avec succès!");
            }
            catch (Exception)
            {
                throw;
                //  MessageBox.Show("Erreur : Demande n'a pas été ajouté !" + ex.Message);
            }
        }

        public void DeleteDemande(int id)
        {
            try
            {
                gestion_agentEntities1 context = new gestion_agentEntities1();
                var t = context.Demande.Single(o => o.id == id);

                if (!t.opinion.HasValue)
                {
                    context.Demande.Remove(t);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Demande non annulée déjà traiter");
                } 
            }
            catch (DbUpdateException exx)
            {
                throw exx;


            }
            catch (Exception ex)
            {
                throw ex;
                // MessageBox.Show("Erreur : Demande n'a pas été Supprimer !"+ ex.Message + " Il se peut qu'il contient des références à d'autres objets. Pour le supprimer : supprimez d'abord toute ces références.");
            }

        }

        public List<Demande> GetAllDemande()
        {
            try
            {
                gestion_agentEntities1 context = new gestion_agentEntities1();
                return context.Demande.ToList();
            }
            catch (Exception)
            {

                throw;
            }

        }

        //public Demande GetDemandeParDefaut()
        //{
        //    try
        //    {
        //        using (gestion_agentEntities1 context = new gestion_agentEntities1())
        //        {
        //            Demande u = context.Demande.FirstOrDefault(e => e.DEFAUT == true);
        //            if (u == null)
        //            {
        //                u = context.Demande.FirstOrDefault();
        //                if (u == null)
        //                {
        //                    u = new Demande();
        //                    u.Demande_LIBELE = "Unité";
        //                    u.REMARQUE = "Unité par défaut";
        //                    u.DEFAUT = true;
        //                    context.Demande.Add(u);
        //                    context.SaveChanges();
        //                    context.Entry(u).GetDatabaseValues();
        //                }
        //                else
        //                {
        //                    u.DEFAUT = true;
        //                    context.SaveChanges();
        //                }
        //                return u;

        //            }
        //            else
        //            {
        //                return u;
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}



        //internal Demande CreateIfNotExist(string celValueUnit4)
        //{
        //    try
        //    {
        //        using (gestion_agentEntities1 context = new gestion_agentEntities1())
        //        {
        //            Demande u = context.Demande.FirstOrDefault(e => e.Demande_LIBELE.Equals(celValueUnit4));
        //            if (u == null)
        //            {
        //                u = new Demande();
        //                u.Demande_LIBELE = celValueUnit4;
        //                u.DEFAUT = false;
        //                context.Demande.Add(u);
        //                context.SaveChanges();
        //                context.Entry(u).GetDatabaseValues();
        //                return u;
        //            }
        //            else
        //            {
        //                return u;
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
    }
}