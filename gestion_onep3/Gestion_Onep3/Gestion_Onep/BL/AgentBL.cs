using Gestion_Onep.MODEL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Onep.BL
{
    public class AgentBL
    {
        private static AgentBL _Instance;
        public static AgentBL Instance
        {
            get
            { 
                 
                if (_Instance == null)
                    _Instance = new AgentBL();
                return _Instance;
            }
        }

        //public void cleardefault()
        //{
        //    try
        //    {
        //        gestion_agentEntities1 context = new gestion_agentEntities1();
        //        context.Agent.tolist().foreach (x => x.defaut = false);
        //        context.savechanges();
        //    }
        //    catch (exception)
        //    {
        //        throw;
        //    }
        //}
        public void UpdateAgent(agent newAgent)
        {
            try
            {
                gestion_agentEntities1 context = new gestion_agentEntities1();
                agent oldAgent = context.agent.FirstOrDefault(o => o.id == newAgent.id);
                context.Entry(oldAgent).CurrentValues.SetValues(newAgent);
                context.SaveChanges();
                //MessageBox.Show("Modification : Agent a  été modifié avec succès!");
            }
            catch (Exception)
            {
                throw;
                //MessageBox.Show("Erreur : Agent n'a pas été modifié !" + ex.Message);
            }
        }

        public agent GetAgentById(int id)
        {
            try
            {
                gestion_agentEntities1 context = new gestion_agentEntities1();
                agent t = context.agent.Where(e => e.id == id).FirstOrDefault<agent>();
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
        public agent GetAgentBLByName(string name)
        {
            try
            {
                gestion_agentEntities1 context = new gestion_agentEntities1();
                agent t = context.agent.Where(e => e.Nom == name).FirstOrDefault<agent>();
                return t;
            }
            catch (Exception)
            {

                throw;
            }

        }
        //public List<agent> GetAgentBLByType(string typeId)
        //{
        //    try
        //    {
        //        gestion_agentEntities1 context = new gestion_agentEntities1();
        //        return context.agent.Where(e => e.type == typeId).ToList();
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //}

        public agent getCredencial(string UserName, string Passwword)
        {
            try
            {
                gestion_agentEntities1 context = new gestion_agentEntities1();
                return context.agent.SingleOrDefault(x => x.UserName == UserName && x.Password == Passwword);
                
                //   MessageBox.Show("Insertion : Agent a été ajouté avec succès!");
            }
            catch (Exception)
            {
                throw;
                //  MessageBox.Show("Erreur : Agent n'a pas été ajouté !" + ex.Message);
            }
        }

        public void AddAgent(agent t)
        {
            try
            {
                gestion_agentEntities1 context = new gestion_agentEntities1();
                context.agent.Add(t);
                context.SaveChanges();
                //   MessageBox.Show("Insertion : Agent a été ajouté avec succès!");
            }
            catch (Exception)
            {
                throw;
                //  MessageBox.Show("Erreur : Agent n'a pas été ajouté !" + ex.Message);
            }
        }

        public void DeleteAgent(int id)
        {
            try
            {
                 
                var context = new gestion_agentEntities1();
                var t = context.agent.Single(o => o.id == id);
                context.agent.Remove(t);
                context.SaveChanges();
                //  MessageBox.Show("Suppression : Agent a été Supprimé avec succès!");
            }
            catch (DbUpdateException exx)
            {
                throw exx;


            }
            catch (Exception ex)
            {
                throw ex;
                // MessageBox.Show("Erreur : Agent n'a pas été Supprimer !"+ ex.Message + " Il se peut qu'il contient des références à d'autres objets. Pour le supprimer : supprimez d'abord toute ces références.");
            }

        }

        public List<agent> GetAllAgent()
        {
            try
            {
                gestion_agentEntities1 context = new gestion_agentEntities1();
                return context.agent.ToList();
            }
            catch (Exception)
            {

                throw;
            }

        }

        //public Agent GetAgentParDefaut()
        //{
        //    try
        //    {
        //        using (gestion_agentEntities1 context = new gestion_agentEntities1())
        //        {
        //            Agent u = context.Agent.FirstOrDefault(e => e.DEFAUT == true);
        //            if (u == null)
        //            {
        //                u = context.Agent.FirstOrDefault();
        //                if (u == null)
        //                {
        //                    u = new Agent();
        //                    u.Agent_LIBELE = "Unité";
        //                    u.REMARQUE = "Unité par défaut";
        //                    u.DEFAUT = true;
        //                    context.Agent.Add(u);
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



        //internal Agent CreateIfNotExist(string celValueUnit4)
        //{
        //    try
        //    {
        //        using (gestion_agentEntities1 context = new gestion_agentEntities1())
        //        {
        //            Agent u = context.Agent.FirstOrDefault(e => e.Agent_LIBELE.Equals(celValueUnit4));
        //            if (u == null)
        //            {
        //                u = new Agent();
        //                u.Agent_LIBELE = celValueUnit4;
        //                u.DEFAUT = false;
        //                context.Agent.Add(u);
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