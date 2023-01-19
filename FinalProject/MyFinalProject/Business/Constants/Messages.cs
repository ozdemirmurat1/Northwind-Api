using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";

        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime="Sistem Bakımda";
        public static string ProductsListed="Ürünler Listelendi";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 20 ürün olabilir";
        public static string ProductNameAlreadyExists="Böyle bir ürün ismi zaten mevcut";
        public static string CategoryLimitExceed="Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied="Yetkiniz Yok";
        public static string UserRegistered="Kayıt başarılı";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Hatalı parola girdiniz.";
        public static string SuccessfulLogin="Oturum açma işlemi başarılı";
        public static string UserAlreadyExists="Böyle bir kullanıcı mevcut";
        public static string AccessTokenCreated="Access Token Oluşturuldu";
    }
}
