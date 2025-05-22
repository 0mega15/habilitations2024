using Microsoft.VisualStudio.TestTools.UnitTesting;
using habilitations2024.dal;
using habilitations2024.controller;
using habilitations2024.model;
using habilitations2024.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using habilitations2024.bddmanager;

namespace habilitations2024.dal.Tests
{
    [TestClass()]
    public class DeveloppeurAccessTests
    {
        [TestMethod()]
        public void DeveloppeurAccessTest()
        {

        }

        [TestMethod()]
        public void ControleAuthentificationTest()
        {

        }

        [TestMethod()]
        public void GetLesDeveloppeursTestProfilNull()
        {
            BddManager bddManager = BddManager.GetInstance("server=localhost;user id=habilitations;password=motdepasseuser;database=habilitations;");
            string req = "SELECT COUNT(*) FROM developpeur d JOIN profil p ON d.idprofil = p.idprofil";

            // Test de la méthode GetLesDeveloppeurs avec un profil null
            DeveloppeurAccess developpeurAccess = new DeveloppeurAccess();
            List<Developpeur> developpeurs = developpeurAccess.GetLesDeveloppeurs(null);
            Assert.AreEqual((long)bddManager.ReqSelect(req)[0][0], developpeurs.Count);

        }

        [TestMethod()]
        public void GetLesDeveloppeursTestProfilNotNull()
        {
            List<string> lstProfils = new List<string> { "stagiaire", "designer", "dev-front", "dev-back", "admin" };
            List<int> nbProfilSQL = new List<int>();
            List<int> nbProfilTrouve = new List<int>();
            BddManager bddManager = BddManager.GetInstance("server=localhost;user id=habilitations;password=motdepasseuser;database=habilitations;");

            foreach (string profil in lstProfils)
            {
                DeveloppeurAccess developpeurAccess = new DeveloppeurAccess();
                List<Developpeur> developpeurs = developpeurAccess.GetLesDeveloppeurs(profil);
                string req = $"SELECT COUNT('{profil}') FROM developpeur d JOIN profil p ON d.idprofil = p.idprofil WHERE p.nom = '{profil}'";
                nbProfilTrouve.Add(developpeurs.Count);
                nbProfilSQL.Add(Convert.ToInt32(bddManager.ReqSelect(req)[0][0]));

            }
            CollectionAssert.AreEqual(nbProfilSQL, nbProfilTrouve);

        }

        [TestMethod()]
        public void DelDepveloppeurTest()
        {

        }

        [TestMethod()]
        public void AddDeveloppeurTest()
        {

        }

        [TestMethod()]
        public void UpdateDeveloppeurTest()
        {

        }

        [TestMethod()]
        public void UpdatePwdTest()
        {

        }
    }
}