using PireksCihazEntegrasyonu.Args;
using System;
using System.Linq;

namespace PireksCihazEntegrasyonu
{
    public static class Tools
    {
        public static object Clone(object value)
        {

            if (value != null)
            {
                var serialzedObject = Newtonsoft.Json.JsonConvert.SerializeObject(value);
                var clonedObject = Newtonsoft.Json.JsonConvert.DeserializeObject(serialzedObject, value.GetType());
                return clonedObject;
            }

            return null;
        }

        public static IArgumans ArgumansWrap(string args)
        {

            if (args is null)
            {
                Logger.WriteInfo("Gelen parametre => null geldi");
                return null;
            }

            Logger.WriteInfo("Gelen parametre => " + args);

            var items = args.Split('+');

            IArgumans argumans = null;

            if (items.Contains("URUN"))
            {
                Logger.WriteInfo("Gelen parametre => URUN");

                argumans = new UrunArgumans
                {
                    Y46ISERID = GetItem<int>(items, 4, "Y46ISERID"),
                    Y46SIRKOD = GetItem<int>(items, 0, "Y46SIRKOD"),
                    Y46TARYIL = GetItem<int>(items, 3, "Y46TARYIL"),
                    Y46USER = GetItem<string>(items, 1, "Y46USER")
                };

                Logger.WriteInfo("Gelen parametre => URUN ayrıştırma başarılı");
            }
            else
            {
                if (items.Contains("ARAC"))
                {
                    Logger.WriteInfo("Gelen parametre => ARAC");

                    argumans = new AracArgumans
                    {
                        Y48GCTUR = GetItem<int>(items, 7, "Y48GCTUR"),
                        Y48HARNO = GetItem<string>(items, 3, "Y48HARNO"),
                        Y48HARTAR = GetItem<DateTime>(items, 5, "Y48HARTAR"),
                        Y48KAPINO = GetItem<string>(items, 6, "Y48KAPINO"),
                        Y48PLAKA = GetItem<string>(items, 4, "Y48PLAKA"),
                        Y48SIRKOD = GetItem<int>(items, 0, "Y48SIRKOD"),
                        Y48USER = GetItem<string>(items, 1, "Y48USER")
                    };
                }

                Logger.WriteInfo("Gelen parametre => ARAC ayrıştırma başarılı");

            }

            return argumans;

        }

        private static T GetItem<T>(string[] items, int index, string paramName)
        {
            try
            {
                var item = items.GetValue(index);
                return (T)Convert.ChangeType(item,typeof(T));
            }
            catch (IndexOutOfRangeException)
            {
                throw new Exception($"{paramName} parametresi için {index} index bulunamadı!");
            }
            catch (FormatException)
            {
                throw new Exception($"{paramName} parametresi için {index} index değer {typeof(T).Name} tipinde olmalı!");
            }
            catch (InvalidCastException)
            {
                throw new Exception($"{paramName} parametresi için {index} index değer {typeof(T).Name} tipinde olmalı!");
            }
            catch (Exception ex)
            {
                throw new Exception($"{paramName} parametresi için {index} index değer {typeof(T).Name} tipi için bilinmeyen hata!", ex);
            }
        }

    }
}
