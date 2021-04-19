using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using WebApplicationRs2;
using WebApplicationRs2.Controllers;
using WebApplicationRs2.Models;
using System.Data.Entity;

namespace WebApplicationRs2.Tests
{
    [TestClass]
    public class DalTests
    {

        [TestMethod]
        public void CreerUtilisateur()
        {
            using (IDal dal = new Dal())
            {
                dal.AjouterUtilisateur("tony", "tony");
                Utilisateur user = dal.ObtenirUtilisateur("tony");

                Assert.IsNotNull(user);
                Assert.AreEqual("tony", user.Prenom);
            }
        }
        [TestMethod]
        public void CreerCommmentaire()
        {
            using (IDal dal = new Dal())
            {
                dal.CreerCommentaire("La bonne fourchette", System.DateTime.Now, 1);
                List<Commentaire> com = dal.ObtientTousLesCommentaires();

                Assert.IsNotNull(com);
                Assert.AreEqual(1, com.Count);
                Assert.AreEqual("La bonne fourchette", com[0].Description);
                Assert.AreEqual("", com[0].createByUser);
            }
        }
  
    }
}
