﻿using System;
using System.Data.SqlClient;

namespace PireksCihazEntegrasyonu.Db
{
    public class DbTool
    {
        private DbTool()
        {

        }
        public static DbTool Instance { get; set; } = new Lazy<DbTool>(() => new DbTool()).Value;

        string GetConnectionString() => System.Configuration.ConfigurationManager.ConnectionStrings["sqlConnector"].ConnectionString;

        SqlConnection GetConnection() => new SqlConnection(GetConnectionString());


        public void InsertUrunTartim(float Y46Brut, float Y46Dara, float Y46Net, int Y46Sirkod, int Y46ISERID, string Y46ETGID, string Y46TYCIP, string Y46TSGPIP, string Y46USER)
        {
            if (UpdateUrunTartim(Y46Brut, Y46Dara, Y46Net, Y46Sirkod, Y46ISERID, Y46ETGID, Y46TYCIP, Y46TSGPIP, Y46USER) > 0)
            {
                return;
            }

            string insertSql = @"Insert Into TARTIMF (Y46SIRKOD,Y46ISERID,Y46TARYIL,Y46BRUT,Y46DARA,Y46NET,Y46ETGID,Y46TYCIP,Y46TSGPIP,Y46GRDATE,Y46SENKRN,Y46GUSER)
                                Values (@Y46Sirkod,@Y46ISERID,@Y46TARYIL,@Y46Brut,@Y46Dara,@Y46Net,@Y46ETGID,@Y46TYCIP,@Y46TSGPIP,GetDate(),0,@Y46USER)";

            using (var connection = GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(insertSql, connection))
                {
                    command.Parameters.Add(new SqlParameter("Y46Sirkod", Y46Sirkod));
                    command.Parameters.Add(new SqlParameter("Y46ISERID", Y46ISERID));
                    command.Parameters.Add(new SqlParameter("Y46TARYIL", DateTime.Now.Year));
                    command.Parameters.Add(new SqlParameter("Y46Brut", Y46Brut));
                    command.Parameters.Add(new SqlParameter("Y46Dara", Y46Dara));
                    command.Parameters.Add(new SqlParameter("Y46Net", Y46Net));
                    command.Parameters.Add(new SqlParameter("Y46ETGID", Y46ETGID));
                    command.Parameters.Add(new SqlParameter("Y46TYCIP", Y46TYCIP));
                    command.Parameters.Add(new SqlParameter("Y46TSGPIP", Y46TSGPIP));
                    command.Parameters.Add(new SqlParameter("Y46USER", Y46USER));

                    command.ExecuteNonQuery();
                }
            }
        }

        public int UpdateUrunTartim(float Y46Brut, float Y46Dara, float Y46Net, int Y46Sirkod, int Y46ISERID, string Y46ETGID, string Y46TYCIP, string Y46TSGPIP, string Y46USER)
        {
            string insertSql = @"Update TARTIMF 
                                    Set
                                        Y46BRUT = @Y46BRUT,
                                        Y46DARA = @Y46DARA,
                                        Y46NET = @Y46NET,
                                        Y46TYCIP = @Y46TYCIP,
                                        Y46TSGPIP =  @Y46TSGPIP,
                                        Y46GRDATE = GetDate()
                                    Where
                                        Y46SIRKOD = @Y46SIRKOD AND
                                        Y46ISERID = @Y46ISERID AND
                                        Y46TARYIL = @Y46TARYIL AND
                                        Y46ETGID = @Y46ETGID AND
                                        Y46SENKRN = 0
                                ";

            using (var connection = GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(insertSql, connection))
                {
                    command.Parameters.Add(new SqlParameter("Y46SIRKOD", Y46Sirkod));
                    command.Parameters.Add(new SqlParameter("Y46ISERID", Y46ISERID));
                    command.Parameters.Add(new SqlParameter("Y46TARYIL", DateTime.Now.Year));
                    command.Parameters.Add(new SqlParameter("Y46BRUT", Y46Brut));
                    command.Parameters.Add(new SqlParameter("Y46DARA", Y46Dara));
                    command.Parameters.Add(new SqlParameter("Y46NET", Y46Net));
                    command.Parameters.Add(new SqlParameter("Y46ETGID", Y46ETGID));
                    command.Parameters.Add(new SqlParameter("Y46TYCIP", Y46TYCIP));
                    command.Parameters.Add(new SqlParameter("Y46TSGPIP", Y46TSGPIP));
                    command.Parameters.Add(new SqlParameter("Y46USER", Y46USER));

                    return command.ExecuteNonQuery();
                }
            }
        }

        public void InsertAracTartim(int Y48SIRKOD, int Y48GCTUR, string Y48USER, string Y48HARNO, string Y48PLAKA, DateTime Y48HARTAR, string Y48KAPINO, float Y48GCAGIR)
        {
            if (UpdateAracTartim(Y48SIRKOD, Y48GCTUR, Y48USER, Y48HARNO, Y48PLAKA, Y48HARTAR, Y48KAPINO, Y48GCAGIR) > 0)
            {
                return;
            }
            string insertSql = @"Insert Into ARACTARTF (Y48SIRKOD,Y48GCTUR,Y48USER,Y48HARNO,Y48PLAKA,Y48HARTAR,Y48KAPINO,Y48GCAGIR,Y48GRDATE,Y48SENKRN)
                                Values (@Y48SIRKOD,@Y48GCTUR,@Y48USER,@Y48HARNO,@Y48PLAKA,@Y48HARTAR,@Y48KAPINO,@Y48GCAGIR,GetDate(),0)";

            using (var connection = GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(insertSql, connection))
                {
                    command.Parameters.Add(new SqlParameter("Y48SIRKOD", Y48SIRKOD));
                    command.Parameters.Add(new SqlParameter("Y48GCTUR", Y48GCTUR));
                    command.Parameters.Add(new SqlParameter("Y48USER", Y48USER));
                    command.Parameters.Add(new SqlParameter("Y48HARNO", Y48HARNO));
                    command.Parameters.Add(new SqlParameter("Y48PLAKA", Y48PLAKA));
                    command.Parameters.Add(new SqlParameter("Y48HARTAR", Y48HARTAR));
                    command.Parameters.Add(new SqlParameter("Y48KAPINO", Y48KAPINO));
                    command.Parameters.Add(new SqlParameter("Y48GCAGIR", Y48GCAGIR));

                    command.ExecuteNonQuery();
                }
            }
        }

        public int UpdateAracTartim(int Y48SIRKOD, int Y48GCTUR, string Y48USER, string Y48HARNO, string Y48PLAKA, DateTime Y48HARTAR, string Y48KAPINO, float Y48GCAGIR)
        {
            string updateSql = @"Update 
                                    ARACTARTF 
                                set 
                                    Y48GCAGIR = @Y48GCAGIR,
                                    Y48GRDATE = GetDate()
                                Where 
                                    Y48SIRKOD = @Y48SIRKOD AND
                                    Y48HARTAR = @Y48HARTAR AND
                                    Y48GCTUR = @Y48GCTUR AND
                                    Y48HARNO = @Y48HARNO AND
                                    Y48PLAKA = @Y48PLAKA AND
                                    Y48KAPINO = @Y48KAPINO AND
                                    Y48SENKRN = 0";

            using (var connection = GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(updateSql, connection))
                {
                    command.Parameters.Add(new SqlParameter("Y48SIRKOD", Y48SIRKOD));
                    command.Parameters.Add(new SqlParameter("Y48GCTUR", Y48GCTUR));
                    command.Parameters.Add(new SqlParameter("Y48USER", Y48USER));
                    command.Parameters.Add(new SqlParameter("Y48HARNO", Y48HARNO));
                    command.Parameters.Add(new SqlParameter("Y48PLAKA", Y48PLAKA));
                    command.Parameters.Add(new SqlParameter("Y48HARTAR", Y48HARTAR));
                    command.Parameters.Add(new SqlParameter("Y48KAPINO", Y48KAPINO));
                    command.Parameters.Add(new SqlParameter("Y48GCAGIR", Y48GCAGIR));

                    return command.ExecuteNonQuery();
                }
            }
        }

    }
}
