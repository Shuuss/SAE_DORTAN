﻿using Npgsql;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows;

namespace DortanApp
{
    public class ApplicationData
    {
        private ObservableCollection<User> LesUsers { get; set; }
        private ObservableCollection<Material> LesMateriaux { get; set; }
        private ObservableCollection<Activity> LesActivites { get; set; }
        private ObservableCollection<Reservation> LesReservations { get; set; }


        private NpgsqlConnection Connexion { get; set; }

        public ApplicationData()
        {
            LesUsers = new ObservableCollection<User>();
            LesMateriaux = new ObservableCollection<Material>();
            LesActivites = new ObservableCollection<Activity>();
            LesReservations = new ObservableCollection<Reservation>();

            ConnexionBD();
            Read();
        }

        public void ConnexionBD()
        {
            try
            {
                Connexion = new NpgsqlConnection
                {
                    ConnectionString = "Server=srv-peda-new; port=5433; Database=cetinkam; Search Path=dortan; uid=cetinkam; password=7jhqDh;"
                };
                Connexion.Open();
                Console.WriteLine("Connexion réussie !");
            }
            catch (Exception e)
            {
                MessageBox.Show("Problème de connexion : " + e.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void DeconnexionBD()
        {
            try
            {
                Connexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Problème à la déconnexion : " + e);
            }
        }

        public int Read()
        {
            const string sql = "SELECT id, identifiant FROM User";
            try
            {
                using (var dataAdapter = new NpgsqlDataAdapter(sql, Connexion))
                {
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    foreach (DataRow res in dataTable.Rows)
                    {
                        User nouveau = new User(int.Parse(res["id"].ToString()), res["identifiant"].ToString());
                        LesUsers.Add(nouveau);
                    }
                    return dataTable.Rows.Count;
                }
            }
            catch (NpgsqlException e)
            {
                Console.WriteLine("Problème de requête : " + e);
                return 0;
            }
        }

        private int MethodeGenerique(string sql)
        {
            try
            {
                using (var cmd = new NpgsqlCommand(sql, Connexion))
                {
                    int nb = cmd.ExecuteNonQuery();
                    return nb; // nb permet de connaître le nb de lignes affectées par un insert, update, delete
                }
            }
            catch (Exception sqlE)
            {
                MessageBox.Show("Problème de requête : " + sqlE.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                return 0;
            }
        }

        public int Create(User u)
        {
            string sql = $"INSERT INTO User (identifiant, mdp) VALUES ('{u.Identifiant}', '{u.Mdp}')";
            return MethodeGenerique(sql);
        }

        public int Update(User u)
        {
            string sql = $"UPDATE User SET identifiant = '{u.Identifiant}', mdp = '{u.Mdp}' WHERE id = {u.Id}";
            return MethodeGenerique(sql);
        }

        public int Delete(User u)
        {
            string sql = $"DELETE FROM User WHERE id = {u.Id}";
            return MethodeGenerique(sql);
        }
    }
}