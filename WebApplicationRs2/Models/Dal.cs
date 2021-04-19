using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Linq;

namespace WebApplicationRs2.Models
{
    public class Dal : IDal
    {
        private BddContext bdd;

        public Dal()
        {
            bdd = new BddContext();
        }

        public void ModifierCommentaire(int id, string description)
        {
            Commentaire com = bdd.Commentaires.FirstOrDefault(resto => resto.Id == id);
            if (com != null)
            {
                com.Description = description;
                bdd.SaveChanges();
            }
        }

        public List<Commentaire> ObtientTousLesCommentaires()
        {
            List<Commentaire> commentaires = bdd.Commentaires.ToList();

            foreach  (Commentaire com  in commentaires)
            {
               
                com.nbJaime = bdd.Votes.Count(r => r.Commentaire.Id == com.Id);

            }

            return commentaires;
        }

        public void Dispose()
        {
            bdd.Dispose();
        }

        public void AjouterJaime(int idCommentaire, int idUtilisateur)
        {
            Vote vote = new Vote
            {
                Commentaire = bdd.Commentaires.First(r => r.Id == idCommentaire),
                Utilisateur = bdd.Utilisateurs.First(u => u.Id == idUtilisateur)
            };
            bdd.Votes.Add(vote);
            bdd.SaveChanges();
        }

        public void CreerCommentaire(string nom, DateTime date, int idUser)
        {
            bdd.Commentaires.Add(new Commentaire { Description = nom, Date = date ,createByUser=idUser });

            bdd.SaveChanges();
        }

        public int AjouterUtilisateur(string nom, string motDePasse)
        {
            string motDePasseEncode = EncodeMD5(motDePasse);
            Utilisateur utilisateur = new Utilisateur { Prenom = nom, MotDePasse = motDePasseEncode };
            bdd.Utilisateurs.Add(utilisateur);
            bdd.SaveChanges();
            return utilisateur.Id;
        }

        private string EncodeMD5(string motDePasse)
        {
            string motDePasseSel = "Rs" + motDePasse + "ASP.NET MVC";
            return BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(System.Text.ASCIIEncoding.Default.GetBytes(motDePasseSel)));
        }

        public Utilisateur ObtenirUtilisateur(int id)
        {
            return bdd.Utilisateurs.FirstOrDefault(u => u.Id == id);
        }

        public Vote ObtenirVote(int id,int idUser)
        {
            return bdd.Votes.FirstOrDefault(u => u.Commentaire.Id == id && u.Utilisateur.Id== idUser);
        }

        public Vote SupprimerVote(int id, int idUser)
        {
           Vote vote= bdd.Votes.FirstOrDefault(u => u.Commentaire.Id == id && u.Utilisateur.Id == idUser);
           bdd.Votes.Remove(vote);
           bdd.SaveChanges();

           return null;
        }
        public Commentaire SupprimerCommentaire(int id, int idUser)
        {
            SupprimerAllVotes(id);


            Commentaire com = bdd.Commentaires.FirstOrDefault(u => u.Id == id && u.createByUser == idUser);
            bdd.Commentaires.Remove(com);
            bdd.SaveChanges();

            return null;
        }

        public List<Vote> SupprimerAllVotes(int idCommentaire)
        {
            List<Vote> votes = bdd.Votes.ToList();

            foreach (Vote vote in votes)
            {
                if (vote.Commentaire.Id == idCommentaire)
                {
                    Vote vote_delete = bdd.Votes.FirstOrDefault(u => u.Id == vote.Id);
                    bdd.Votes.Remove(vote_delete);
                }
            }
            bdd.SaveChanges();
            
            return null;
        }

        public Utilisateur ObtenirUtilisateur(string idStr)
        {
            int id;
            if (int.TryParse(idStr, out id))
                return ObtenirUtilisateur(id);
            return null;
        }

        public Utilisateur Authentifier(string nom, string motDePasse)
        {
            string motDePasseEncode = EncodeMD5(motDePasse);
            return bdd.Utilisateurs.FirstOrDefault(u => u.Prenom == nom && u.MotDePasse == motDePasseEncode);
        }
    }

    public interface IDal : IDisposable
    {
        List<Commentaire> ObtientTousLesCommentaires();
        void AjouterJaime(int idCommentaire, int idUtilisateur);
        int AjouterUtilisateur(string nom, string motDePasse);
        void CreerCommentaire(string Description, DateTime date, int idUser);
        Utilisateur ObtenirUtilisateur(int id);
        Utilisateur ObtenirUtilisateur(string idStr);
        Utilisateur Authentifier(string nom, string motDePasse);
        Vote ObtenirVote(int id, int idUser);
        Vote SupprimerVote(int id, int idUser);
        Commentaire SupprimerCommentaire(int id,int idUser);
        void ModifierCommentaire(int id, string description);
    }
}
