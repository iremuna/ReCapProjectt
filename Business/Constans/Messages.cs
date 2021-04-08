using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constans
{
    public class Messages
    {
        public static string CarAdded = "Araba Başarıyla Eklendi";
        public static string CarDeleted = "Araba Başarıyla Silindi";
        public static string CarUpdated = "Araba Başarıyla Güncellendi";
        public static string CarNameIsUnvalid = "Geçersiz isim";
        public static string CarListed = "Arabalar Listelendi!";
        public static string MaintenanceTime = "Sistem bakımda!";

        public static string BrandAdded = "Marka Başarıyla eklendi!";
        public static string BrandDeleted = "Marka Başarıyla silindi!";
        public static string BrandUpdated = "Marka Başarıyla güncellendi!";
        public static string BrandListed = "Markalar Listelendi!";

        public static string ColorAdded = "Renk Başarıyla eklendi!";
        public static string ColorDeleted = "Renk Başarıyla silindi!";
        public static string ColorUpdated = "Renk Başarıyla güncellendi!";
        public static string ColorListed = "Renkler Listelendi!";

        public static string UserAdded = "Kullanıcı Başarıyla eklendi!";
        public static string UserDeleted = "Kullanıcı Başarıyla silindi!";
        public static string UserUpdated = "Kullanıcı Başarıyla güncellendi!";
        public static string UserListed = "Kullanıcılar Listelendi!";

        public static string CustomerAdded = "Müşteri Başarıyla eklendi!";
        public static string CustomerDeleted = "Müşteri Başarıyla silindi!";
        public static string CustomerUpdated = "Müşteri Başarıyla güncellendi!";
        public static string CustomerListed = "Müşteriler Listelendi!";

        public static string RentalAdded = "Kiralama Başarıyla eklendi!";
        public static string RentalDeleted = "Kiralama Başarıyla silindi!";
        public static string RentalUpdated = "Kiralama Başarıyla güncellendi!";
        public static string RentalListed = "Kiralama Listelendi!";
        public static string RentalDetail = "Kiralama detayları :";

        public static string CategoryListed = "Kategori listelendi.";
        public static string CategoryDeleted = "Kategori silindi.";
        public static string CategoryUpdated = "Kategori güncellendi.";
        public static string CategoryAdded = "Kategori listelendi.";

        public static string RentalFailed = "Kiralama işlemi gerçekleştirilemedi!";
        public static string DeliverAdd = "Araba teslim edildi.";

        public static string TakeImagePath  = "Resim ekleyiniz";
        public static string NoCarImages = "Araç resmi bulunamadı.";
        public static string CarImageLimitExceded = "Daha fazla resim yükleyemezsiniz";

        public static string ListSuccess = "Listeleme işlemi başarıyla tamamlandı.";
        public static string DeleteSuccess = "Silme işlemi başarıyla tamamlandı.";
        public static string AddSuccess = "Ekleme işlemi başarıyla tamamlandı.";
        public static string AuthorizationDenied = "Kimlik doğrulamaa reddedildi.";
        public static string UpdateSuccess = "Güncelleme başarılı.";
        public static string AccessTokenCreated = "Erişim sağlandı.";
        public static string UserRegistered = "Kullanıcı kayıtlı.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string PasswordError = "Yanlış parola.";
        public static string UserAlreadyExists = "Kullanıcı mevcut.";
       
      
    }
}
