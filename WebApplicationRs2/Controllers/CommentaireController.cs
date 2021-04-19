using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationRs2.Models;

namespace WebApplicationRs2.Controllers
{
    public class CommentaireController : Controller
    {
        // GET: Commentaire
        [Authorize]
        public ActionResult Index()
        {
            using (IDal dal = new Dal())
            {

                Utilisateur UserConnected = dal.ObtenirUtilisateur(HttpContext.User.Identity.Name);
                ViewData["user_connected"] = UserConnected;
                List<Commentaire> listeDesCommentaires = dal.ObtientTousLesCommentaires();
                return View(listeDesCommentaires);
            }
        }

        public ActionResult Create()
        {
            return View();

        }
        public ActionResult Jaime(Commentaire com)
        {
         
            using (IDal dal = new Dal())
            {
                Utilisateur UserConnected = dal.ObtenirUtilisateur(HttpContext.User.Identity.Name);
                if (!ModelState.IsValid)
                    return View(com);
                Vote comExiste = dal.ObtenirVote(com.Id, UserConnected.Id);

                if (comExiste==null)
                {
                    dal.AjouterJaime(com.Id, UserConnected.Id);

                }
                else
                {
                    dal.SupprimerVote(com.Id, UserConnected.Id);
                }

                return RedirectToAction("Index");
            }

        }

        public ActionResult Delete(Commentaire com)
        {

            using (IDal dal = new Dal())
            {
                Utilisateur UserConnected = dal.ObtenirUtilisateur(HttpContext.User.Identity.Name);

                dal.SupprimerCommentaire(com.Id, UserConnected.Id);


                return RedirectToAction("Index");
            }

        }

        [HttpPost]

        public ActionResult Create( Commentaire com)
        {

            using (IDal dal = new Dal())
            {

                Utilisateur UserConnected = dal.ObtenirUtilisateur(HttpContext.User.Identity.Name);

                if (!ModelState.IsValid)
                    return View(com);
                dal.CreerCommentaire(com.Description, System.DateTime.Now, UserConnected.Id);
                return RedirectToAction("Index");
            }
        }

        public ActionResult Edit(int? id)
        {
            if (id.HasValue)
            {
                using (IDal dal = new Dal())
                {
                    Commentaire com = dal.ObtientTousLesCommentaires().FirstOrDefault(r => r.Id == id.Value);
                    if (com == null)
                        return View("Error");
                    return View(com);
                }
            }
            else
                return View("Error");
        }


        [HttpPost]
        public ActionResult Edit(Commentaire commentaire)
        {
            using (IDal dal = new Dal())
            {
                dal.ModifierCommentaire(commentaire.Id, commentaire.Description);
                return RedirectToAction("Index");
            }
        }
    }
}