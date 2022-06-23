using System.Collections.Generic;
using eShopOnContainers.Core.Models.MyCategory;

namespace eShopOnContainers.Core.Services.MyCategory
{
    public class CategoryMockService:ICategoryService
    {
        private readonly static List<MainCategory> MainCategories = new List<MainCategory>()
        {
                new MainCategory()
                {
                   Id = 1,
                   Title = "Elektronik",
                   IconSource = "elektronik.png"
                },
                new MainCategory()
                {
                    Id = 2,
                    Title = "Giyim & Aksesuar",
                    IconSource = "moda.png"
                },
                new MainCategory()
                {
                    Id = 3,
                    Title = "Kozmetik & Kişisel & Bakım",
                    IconSource = "kozmetik_saglik.png"
                },
                new MainCategory()
                {
                    Id = 4,
                    Title = "Anne & Bebek & Oyuncak",
                    IconSource = "anne_bebek.png"
                },
                new MainCategory()
                {
                    Id = 5,
                    Title = "Ev Dekorasyon ",
                    IconSource = "ev_yasam.png"
                },
                new MainCategory()
                {

                    Id = 6,
                    Title = "Hobi & Oyuncak",
                    IconSource = "hobi_dunyasi.png"
                },
                new MainCategory()
                {
                    Id = 7,
                    Title = "Spor & Outdoor",
                    IconSource = "spor_outdoor.png"
                },
                new MainCategory()
                {
                    Id = 8,
                    Title = "Süpermarket",
                    IconSource = "supermarket.png"
                },
                new MainCategory()
                {
                    Id = 9,
                    Title = "Otomobil & Motosiklet",
                    IconSource = "otomobil_motosiklet.png"
                },
                new MainCategory()
                {
                    Id = 10,
                    Title = "Pet Shop",
                    IconSource = "petshop.png"
                }
        };
        private readonly static List<SubCategory> SubCategories = new List<SubCategory>() {
             new SubCategory()
                {
                   Id = 1,
                   CategoryId = 1,
                   Title = "Bilgisayar & Tablet",
                   IsPopularForElecktronic = true,
                   ImageSource="bilgisayar"
                },
                new SubCategory()
                {
                    Id = 2,
                    CategoryId= 1,
                    Title = "Beyaz Eşya",
                   IsPopularForElecktronic = true,
                   ImageSource="beyazesya",
                },
                new SubCategory()
                {
                    Id = 3,
                    CategoryId= 1,
                    Title = "Elektrikli Ev & Mutfak",
                   IsPopularForElecktronic = true,
                   ImageSource="mutfakaletleri",

                },
                new SubCategory()
                {
                    Id = 4,
                    CategoryId= 1,
                    Title = "Telefonlar & Aksesuarları",
                   IsPopularForElecktronic = true,
                   ImageSource="telefonlar"
                },
                new SubCategory()
                {
                    Id = 5,
                    CategoryId= 1,
                    Title = "Televizyon & Ses Sistemleri",
                   IsPopularForElecktronic = true,
                   ImageSource="televizyon"

                },
                new SubCategory()
                {
                    Id = 6,
                    CategoryId= 1,
                    Title = "Isıtma & Soğutma Sistemleri",
                },
                new SubCategory()
                {
                    Id=7,
                    CategoryId=1,
                    Title="Akılı Güvenlik Sistemleri"
                },
                new SubCategory()
                {
                   Id = 1,
                   CategoryId = 2,
                   Title = "Kadın",
                },
                new SubCategory()
                {
                    Id = 2,
                    CategoryId= 2,
                    Title = "Erkek",
                },
                new SubCategory()
                {
                    Id = 3,
                    CategoryId= 2,
                    Title = "Çocuk Giyim Ürünleri ve Kıyafetleri",
                },
                new SubCategory()
                {
                    Id = 4,
                    CategoryId= 2,
                    Title = "Ayakkabı Bakım Koruma Malzemeleri",
                },
                new SubCategory()
                {
                    Id = 5,
                    CategoryId=2,
                    Title = "Bavul & Valiz",
                },
                new SubCategory()
                {
                   Id = 1,
                   CategoryId = 3,
                   Title = "Kozmetik",
                },
                new SubCategory()
                {
                    Id = 2,
                    CategoryId= 3,
                    Title = "Kişisel Bakım",
                },
                new SubCategory()
                {
                   Id = 1,
                   CategoryId = 4,
                   Title = "Bebek Oyuncak",
                   IsPopularForBaby = true,
                   ImageSource = "bebekoyuncak.jpg"
                },
                new SubCategory()
                {
                   Id = 2,
                   CategoryId = 4,
                   Title = "Oto Koltuğu & ana kucağı",
                   IsPopularForBaby = true,
                   ImageSource = "bebekotokoltuk.jpeg"
                },
                new SubCategory()
                {
                   Id = 3,
                   CategoryId = 4,
                   Title = "Bebek Bezi & Islak Mendil",
                   IsPopularForBaby = true,
                   ImageSource = "bebekbakim.jpg",
                },
                new SubCategory()
                {
                   Id = 4,
                   CategoryId = 4,
                   Title = "Bebek Giyim",
                },
                new SubCategory()
                {
                   Id = 5,
                   CategoryId = 4,
                   Title = "Bebek Güvenliği",
                },
                new SubCategory()
                {
                   Id = 6,
                   CategoryId = 4,
                   Title = "Bebek Maması",
                   IsPopularForBaby = true,
                   ImageSource = "bebekmamasi.jpg"
                },
                new SubCategory()
                {
                   Id = 7,
                   CategoryId = 4,
                   Title = "Biberon ,Emzik ve Aksesuarları",
                },
                new SubCategory()
                {
                   Id = 1,
                   CategoryId = 5,
                   Title = "Mobilya",
                },
                new SubCategory()
                {
                   Id = 2,
                   CategoryId = 5,
                   Title = "Ev Tekstii",
                },
                new SubCategory()
                {
                   Id = 3,
                   CategoryId = 5,
                   Title = "Mutfak Araçları ve Gereçleri",
                },
                new SubCategory()
                {
                   Id = 4,
                   CategoryId = 5,
                   Title = "Dekorasyon",
                },
                new SubCategory()
                {
                   Id = 5,
                   CategoryId = 5,
                   Title = "Banyo",
                },
                new SubCategory()
                {
                   Id = 1,
                   CategoryId = 6,
                   Title = "Kız Çocuk Oyuncakları",
                },
                new SubCategory()
                {
                   Id = 2,
                   CategoryId = 6,
                   Title = "Erkek Çocuk Oyuncakları",
                },
                new SubCategory()
                {
                   Id = 3,
                   CategoryId = 6,
                   Title = "Aktivite ve Eğitici Oyuncaklar",
                },
                new SubCategory()
                {
                   Id = 4,
                   CategoryId = 6,
                   Title = "Oyuncak Arabalar",
                },
                new SubCategory()
                {
                   Id = 5,
                   CategoryId = 6,
                   Title = "Kostüm ve Parti Malzemeleri",
                },
                new SubCategory()
                {
                   Id = 6,
                   CategoryId = 6,
                   Title = "Puzzlelar",
                },
                new SubCategory()
                {
                   Id = 7,
                   CategoryId = 6,
                   Title = "Kutu Oyunları",
                },
                new SubCategory()
                {
                   Id = 1,
                   CategoryId = 7,
                   Title = "Spor & Fitness",
                },
                new SubCategory()
                {
                   Id = 2,
                   CategoryId = 7,
                   Title = "Outdoor",
                },
                new SubCategory()
                {
                   Id = 1,
                   CategoryId = 8,
                   Title = "Deterjan Temizlik Ürünleri",
                },
                new SubCategory()
                {
                   Id = 2,
                   CategoryId = 8,
                   Title = "Kağıt Ürünleri",
                },
                new SubCategory()
                {
                   Id = 3,
                   CategoryId = 8,
                   Title = "Mutfak Sarf Malzemeleri",
                },
                new SubCategory()
                {
                   Id = 4,
                   CategoryId = 8,
                   Title = "İçecek",
                },
                new SubCategory()
                {
                   Id = 5,
                   CategoryId = 8,
                   Title = "Gıda",
                },
                new SubCategory()
                {
                   Id = 6,
                   CategoryId = 8,
                   Title = "Kuru Gıdalar",
                },
                new SubCategory()
                {
                   Id = 1,
                   CategoryId = 9,
                   Title = "Oto Aksesuar",
                },
                new SubCategory()
                {
                   Id = 2,
                   CategoryId = 9,
                   Title = "Oto Ses Ve Görüntü Sistemleri",
                },
                new SubCategory()
                {
                   Id = 3,
                   CategoryId = 9,
                   Title = "Oto Lastik ve Jant",
                },
                new SubCategory()
                {
                   Id = 4,
                   CategoryId = 9,
                   Title = "Yedek Parçalar",
                },
                new SubCategory()
                {
                   Id = 5,
                   CategoryId = 9,
                   Title = "Modifiye Ve Tuning",
                },
                new SubCategory()
                {
                   Id = 6,
                   CategoryId = 9,
                   Title = "Motosiklet,Utv ve Atv",
                },
                new SubCategory()
                {
                   Id = 7,
                   CategoryId = 9,
                   Title = "4x4 Off Road",
                },
                new SubCategory()
                {
                   Id = 1,
                   CategoryId = 10,
                   Title = "Köpek",
                },
                new SubCategory()
                {
                   Id = 2,
                   CategoryId = 10,
                   Title = "Kedi",
                },
                new SubCategory()
                {
                   Id = 3,
                   CategoryId = 10,
                   Title = "Kuş",
                },
                new SubCategory()
                {
                   Id = 4,
                   CategoryId = 10,
                   Title = "Balık",
                },
                new SubCategory()
                {
                   Id = 5,
                   CategoryId = 10,
                   Title ="Hamster & Tavşan",
                },
                new SubCategory()
                {
                   Id = 6,
                   CategoryId = 10,
                   Title = "Kaplumbağa",
                }
        };
        private readonly static List<SubOfSubCategory> SubOfSubCategories = new List<SubOfSubCategory>() {
        new SubOfSubCategory()
                {
                   Id = 1,
                   CategoryId = 1,
                   SubCategoryId = 1,
                   Title = "Masaüstü Bilgisayarlar",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId= 1,
                   SubCategoryId = 1,
                    Title = "Tabletler",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId= 1,
                   SubCategoryId = 1,
                    Title = "Veri Depolama",

                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId= 1,
                   SubCategoryId = 1,
                    Title = "Bilgisayar Bileşenleri",

                },
                new SubOfSubCategory()
                {
                    Id = 5,
                    CategoryId= 1,
                   SubCategoryId = 1,
                    Title = "Çevre Birimleri",
                },
                new SubOfSubCategory()
                {
                    Id = 6,
                    CategoryId = 1,
                    SubCategoryId = 1,
                    Title = "Monitörler",
                },
                new SubOfSubCategory()
                {
                    Id =7,
                    CategoryId = 1,
                    SubCategoryId = 1,
                    Title = "Yazılım Ürünleri"
                },
                new SubOfSubCategory()
                {
                    Id = 8,
                    CategoryId = 1,
                    SubCategoryId = 1,
                    Title = "Ağ & Modem",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 1,
                    SubCategoryId = 2,
                    Title = "Çamaşır Makineleri",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 1,
                    SubCategoryId = 2,
                    Title = "Bulaşık Makineleri",
                },
                new SubOfSubCategory()
                {
                    Id =3 ,
                    CategoryId = 1,
                    SubCategoryId = 2,
                    Title = "Ankastre Setler",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 1,
                    SubCategoryId = 2,
                    Title = "Davlumbazlar",
                },
                new SubOfSubCategory()
                {
                    Id = 5,
                    CategoryId = 1,
                    SubCategoryId = 2,
                    Title = "Aspiratörler",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Title = "Elektrikli Mutfak Aletleri",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Title = "Elektrikli Süpürgeler",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Title = "ütüler",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Title = "Dikiş Makineleri",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 1,
                    SubCategoryId = 4,
                    Title = "Cep Telefonları",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 1,
                    SubCategoryId = 4,
                    Title = "Cep Telefonu Aksesuarları",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 1,
                    SubCategoryId = 4,
                    Title = "Giyilebilir Teknoloji Ürünleri",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 1,
                    SubCategoryId = 4,
                    Title = "Cep Telefonu Yedek Parçaları",
                },
                new SubOfSubCategory()
                {
                    Id = 5,
                    CategoryId = 1,
                    SubCategoryId = 4,
                    Title = "Telsiz ve Masaüstü Telefonlar",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 1,
                    SubCategoryId = 5,
                    Title = "Televizyonlar",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 1,
                    SubCategoryId = 5,
                    Title = "Televizyon Aksesuarları ",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 1,
                    SubCategoryId = 5,
                    Title = "Uydu Sistemleri",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 1,
                    SubCategoryId = 5,
                    Title = "Projeksiyon Sistemleri",
                },
                new SubOfSubCategory()
                {
                    Id = 5,
                    CategoryId = 1,
                    SubCategoryId = 5,
                    Title = "Bluetooth Hoparlörler",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 1,
                    SubCategoryId = 6,
                    Title = "Kombiler",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 1,
                    SubCategoryId = 6,
                    Title = "Klima & Aksesuarlar",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 1,
                    SubCategoryId = 6,
                    Title = "Termostatlar",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 1,
                    SubCategoryId = 6,
                    Title = "Termosifonlar",
                },
                new SubOfSubCategory()
                {
                    Id = 5,
                    CategoryId = 1,
                    SubCategoryId = 6,
                    Title = "Şofbenler",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 1,
                    SubCategoryId = 7,
                    Title = "Güvenlik Kameraları",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 1,
                    SubCategoryId = 7,
                    Title = "Kayıt ve Görüntüleme Sistemleri",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 1,
                    SubCategoryId = 7,
                    Title = "Aktif Network Ürünleri",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 1,
                    SubCategoryId = 7,
                    Title = "Pasif Network Ürünleri",
                },
                new SubOfSubCategory()
                {
                    Id = 5,
                    CategoryId = 1,
                    SubCategoryId = 7,
                    Title = "Güvenlik Sistemi Bileşenleri",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 2,
                    SubCategoryId = 1,
                    Title = "Giyim",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 2,
                    SubCategoryId = 1,
                    Title = "İç Giyim",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 2,
                    SubCategoryId = 1,
                    Title = "Plaj Giyim",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 2,
                    SubCategoryId = 1,
                    Title = "Kadın Giyim",
                },
                new SubOfSubCategory()
                {
                    Id = 5,
                    CategoryId = 2,
                    SubCategoryId = 1,
                    Title = "Kadın Ayakkabı",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 2,
                    SubCategoryId = 2,
                    Title = "Giyim",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 2,
                    SubCategoryId = 2,
                    Title = "İç Giyim",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 2,
                    SubCategoryId = 2,
                    Title = "Erkek Büyük Beden",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 2,
                    SubCategoryId = 2,
                    Title = "Erkek Ayakkabı",
                },
                new SubOfSubCategory()
                {
                    Id = 5,
                    CategoryId = 2,
                    SubCategoryId = 2,
                    Title = "Erkek Aksesuar",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 2,
                    SubCategoryId = 3,
                    Title = "Kız Çocuk Ürünleri",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 2,
                    SubCategoryId =3,
                    Title = "Erkek Çocuk Ürünleri",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 2,
                    SubCategoryId = 4,
                    Title = "Ayakkabı Kalıbı",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 2,
                    SubCategoryId = 4,
                    Title = "Ayakkabı Kutusu",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 2,
                    SubCategoryId = 4,
                    Title = "Bakım & Koruma ",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 2,
                    SubCategoryId = 4,
                    Title = "Tabanlık",
                },
                new SubOfSubCategory()
                {
                    Id = 5,
                    CategoryId = 2,
                    SubCategoryId = 4,
                    Title = "Onarım Malzemeleri",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 2,
                    SubCategoryId = 5,
                    Title = "Valiz",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 2,
                    SubCategoryId = 5,
                    Title = "Valiz Setleri",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 2,
                    SubCategoryId = 5,
                    Title = "Valiz Kılıfları",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 2,
                    SubCategoryId = 5,
                    Title = "Valiz Aksesuarları",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 3,
                    SubCategoryId = 1,
                    Title = "Parfüm",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 3,
                    SubCategoryId = 1,
                    Title = "Cilt Bakımı",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 3,
                    SubCategoryId = 1,
                    Title = "Makyaj Ürünleri",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 3,
                    SubCategoryId = 1,
                    Title = "Güneş Ürünleri",
                },
                new SubOfSubCategory()
                {
                    Id = 5,
                    CategoryId = 3,
                    SubCategoryId = 1,
                    Title = "Güneş Krem ve Losyonları",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 3,
                    SubCategoryId = 2,
                    Title = "Kişisel Bakım Ürünleri",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 4,
                    SubCategoryId = 1,
                    Title = "Çıngırak",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 4,
                    SubCategoryId = 1,
                    Title = "Dişliik & Diş Halkaları",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 4,
                    SubCategoryId = 1,
                    Title = "Yürüteç Hoppala",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 4,
                    SubCategoryId = 1,
                    Title = "Banyo Oyuncak",
                },
                new SubOfSubCategory()
                {
                    Id = 5,
                    CategoryId = 4,
                    SubCategoryId = 1,
                    Title = "Diğer Bebek Oyuncakları",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 4,
                    SubCategoryId = 2,
                    Title = "Ev Tipi Ana Kucağı",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 4,
                    SubCategoryId = 2,
                    Title = "Oto Koltuğu",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 4,
                    SubCategoryId = 2,
                    Title = "Yüksetici & Aksesuar",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 4,
                    SubCategoryId = 2,
                    Title = "Oto Koltuğu Aksesuarları",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 4,
                    SubCategoryId = 3,
                    Title = "Bebek Bezi",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 4,
                    SubCategoryId = 3,
                    Title = "Islak Mendil & Havlu",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 4,
                    SubCategoryId = 3,
                    Title = "Alt Açma",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 4,
                    SubCategoryId = 4,
                    Title = "Kız Bebek",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 4,
                    SubCategoryId = 4,
                    Title = "Erkek Bebek",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 4,
                    SubCategoryId = 5,
                    Title = "Bebek Telsizi",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 4,
                    SubCategoryId = 5,
                    Title = "Kamera",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 4,
                    SubCategoryId = 5,
                    Title = "Kilili köşe Koruyucusu",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 4,
                    SubCategoryId = 5,
                    Title = "Oto Güvenlik ürünleri",
                },
                new SubOfSubCategory()
                {
                    Id = 5,
                    CategoryId = 4,
                    SubCategoryId = 5,
                    Title = "Priz Emniyeti",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 4,
                    SubCategoryId = 6,
                    Title = "Biberon Maması"
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 4,
                    SubCategoryId = 6,
                    Title = "Kaşık Maması",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 4,
                    SubCategoryId = 6,
                    Title = "Kavanoz Maması",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 4,
                    SubCategoryId = 6,
                    Title = "Besin Takviyeleri",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 4,
                    SubCategoryId = 7,
                    Title = "Emzik & Aksesuarları",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 4,
                    SubCategoryId = 7,
                    Title = "Sebze Meyve Filesi",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 4,
                    SubCategoryId = 7,
                    Title = "Biberon",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 5,
                    SubCategoryId = 1,
                    Title = "Antre & Hol",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 5,
                    SubCategoryId = 1,
                    Title = "Mutfak Dolapları",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 5,
                    SubCategoryId = 1,
                    Title = "Yatak Odası",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 5,
                    SubCategoryId = 1,
                    Title = "Genç Ve Çocuk Odası",
                },
                new SubOfSubCategory()
                {
                    Id = 5,
                    CategoryId = 5,
                    SubCategoryId = 1,
                    Title = "Mutfak Mobilyası",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 5,
                    SubCategoryId = 2,
                    Title = "Perdeler",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 5,
                    SubCategoryId = 2,
                    Title = "Banyo Tekstili",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 5,
                    SubCategoryId = 2,
                    Title = "Nevresim Takımı",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 5,
                    SubCategoryId = 2,
                    Title = "Yorgan & Yastık & Alez",
                },
                new SubOfSubCategory()
                {
                    Id = 5,
                    CategoryId = 5,
                    SubCategoryId = 2,
                    Title = "Yataklar",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 5,
                    SubCategoryId = 3,
                    Title = "Çatal & Kaşık & Bıçaklar",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 5,
                    SubCategoryId = 3,
                    Title = "Tencere Setleri & Tencereler",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 5,
                    SubCategoryId = 3,
                    Title = "Düdüklü Tencereler",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 5,
                    SubCategoryId = 3,
                    Title = "Tava & Tava Setleri",
                },
                new SubOfSubCategory()
                {
                    Id = 5,
                    CategoryId = 5,
                    SubCategoryId = 3,
                    Title = "Kahvaltı Takımları",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 5,
                    SubCategoryId = 4,
                    Title = "Tasarım Ürünler",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 5,
                    SubCategoryId = 4,
                    Title = "Ev Düzenleme ve Saklama",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 5,
                    SubCategoryId = 4,
                    Title = "Biblo",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 5,
                    SubCategoryId = 4,
                    Title = "Dekoratif Objeler",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 5,
                    SubCategoryId = 5,
                    Title = "banyo Aksesuarları",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 6,
                    SubCategoryId = 1,
                    Title = "Bebekler",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 6,
                    SubCategoryId = 1,
                    Title = "Oyun Setler",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 6,
                    SubCategoryId = 2,
                    Title = "oyuncak Silahlar & Tabancalr",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 6,
                    SubCategoryId = 2,
                    Title = "Oyun Setleri",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 6,
                    SubCategoryId = 3,
                    Title = "Bilim Setleri",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 6,
                    SubCategoryId = 3,
                    Title = "Bloklar",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 6,
                    SubCategoryId = 3,
                    Title = "Legolar",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 6,
                    SubCategoryId = 3,
                    Title = "Oyun Hamurları",
                },
                new SubOfSubCategory()
                {
                    Id = 5,
                    CategoryId = 6,
                    SubCategoryId = 3,
                    Title = "Eğitici Kartlar",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 6,
                    SubCategoryId = 4,
                    Title = "Garajlar",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 6,
                    SubCategoryId = 4,
                    Title = "Ölçekli Modeller",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 6,
                    SubCategoryId = 4,
                    Title = "Uzaktan Kumandalı Arabalar",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 6,
                    SubCategoryId = 4,
                    Title = "Kamyon ve Tırlar",
                },
                new SubOfSubCategory()
                {
                    Id = 5,
                    CategoryId = 6,
                    SubCategoryId = 4,
                    Title = "İş Makinaları",
                },
                new SubOfSubCategory()
                {
                    Id = 6,
                    CategoryId = 6,
                    SubCategoryId = 4,
                    Title = "Çek Bırak Arabalar",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 6,
                    SubCategoryId = 5,
                    Title = "Kostüm ve Aksesuarlar",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 6,
                    SubCategoryId = 5,
                    Title = "Maskeler",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 6,
                    SubCategoryId = 5,
                    Title = "Parti Malzemeleri",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 6,
                    SubCategoryId = 6,
                    Title = "3 Boyutlu Puzzlelar",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 6,
                    SubCategoryId = 6,
                    Title = "Ahşap Puzzlelar",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 6,
                    SubCategoryId = 6,
                    Title = "Yetişkin Puzzle",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 6,
                    SubCategoryId = 6,
                    Title = "Çocuk Puzzle",
                },
                new SubOfSubCategory()
                {
                    Id = 5,
                    CategoryId = 6,
                    SubCategoryId = 6,
                    Title = "Puzzle Aksesuarları",
                },
                new SubOfSubCategory()
                {
                    Id = 6,
                    CategoryId = 6,
                    SubCategoryId = 6,
                    Title = "Puzzle Halıları",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 6,
                    SubCategoryId = 7,
                    Title = "Kutu Oyunları",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 6,
                    SubCategoryId = 7,
                    Title = "Eğitsel Oyunlar",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 7,
                    SubCategoryId = 1,
                    Title = "Fitness & Kondisyon",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 7,
                    SubCategoryId = 1,
                    Title = "Bisiklet",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 7,
                    SubCategoryId = 1,
                    Title = "Vücüt Geliştirme Aletleri",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 7,
                    SubCategoryId = 1,
                    Title = "Sporcu Besinleri",
                },
                new SubOfSubCategory()
                {
                    Id = 5,
                    CategoryId = 7,
                    SubCategoryId = 1,
                    Title = "Spor Branşları",
                },
                new SubOfSubCategory()
                {
                    Id = 6,
                    CategoryId = 7,
                    SubCategoryId = 1,
                    Title = "Spor Giyim & Aksesuar",
                },
                new SubOfSubCategory()
                {
                    Id = 7,
                    CategoryId = 7,
                    SubCategoryId = 1,
                    Title = "Taraftar ürünleri",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 7,
                    SubCategoryId = 2,
                    Title = "Kamp & Kampçılık Malzemeleri",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 7,
                    SubCategoryId = 2,
                    Title = "Outdoor Giyim & Ayakkabı",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 7,
                    SubCategoryId = 2,
                    Title = "Şişme Su Aktivite Ürünleri",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 7,
                    SubCategoryId = 2,
                    Title = "Kara & Balık Av Malzemeleri ",
                },
                new SubOfSubCategory()
                {
                    Id = 5,
                    CategoryId = 7,
                    SubCategoryId = 2,
                    Title = "Tekne & Tekme Malzemeleri",
                },
                new SubOfSubCategory()
                {
                    Id = 6,
                    CategoryId = 7,
                    SubCategoryId = 2,
                    Title = "Doğa Sporları",
                },
                new SubOfSubCategory()
                {
                    Id = 7,
                    CategoryId = 7,
                    SubCategoryId = 2,
                    Title = "Kış Sporları",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 8,
                    SubCategoryId = 1,
                    Title = "Çamaşır Deterjanları ",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 8,
                    SubCategoryId = 1,
                    Title = "Bulaşık Deterjanları",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 8,
                    SubCategoryId = 1,
                    Title = "Temizlik Gereçleri",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 8,
                    SubCategoryId = 1,
                    Title = "Genel Temizlik",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 8,
                    SubCategoryId = 2,
                    Title = "Tuvalet Kağıdı",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 8,
                    SubCategoryId = 2,
                    Title = "Kağıt Havlu",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 8,
                    SubCategoryId = 2,
                    Title = "Peçete",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 8,
                    SubCategoryId = 2,
                    Title = "Kağıt Mendil",
                },
                new SubOfSubCategory()
                {
                    Id = 5,
                    CategoryId = 8,
                    SubCategoryId = 2,
                    Title = "Klozet Örtüsü",
                },
                new SubOfSubCategory()
                {
                    Id = 6,
                    CategoryId = 8,
                    SubCategoryId = 2,
                    Title = "Islak Mendil",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 8,
                    SubCategoryId = 3,
                    Title = "Alüminyum Folyo",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 8,
                    SubCategoryId = 3,
                    Title = "Streç Film",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 8,
                    SubCategoryId = 3,
                    Title = "Buzdolabı Poşeti",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 8,
                    SubCategoryId = 3,
                    Title = "Çöp Torbası",
                },
                new SubOfSubCategory()
                {
                    Id = 5,
                    CategoryId = 8,
                    SubCategoryId = 3,
                    Title = "Pişirme Kağıdı",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 8,
                    SubCategoryId = 4,
                    Title = "Çay",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 8,
                    SubCategoryId = 4,
                    Title = "Kahve",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 8,
                    SubCategoryId = 4,
                    Title = "Gazsız İçecek",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 8,
                    SubCategoryId = 4,
                    Title = "Gazlı İçecek",
                },
                new SubOfSubCategory()
                {
                    Id = 5,
                    CategoryId = 8,
                    SubCategoryId = 4,
                    Title = "Su,Maden Suyu",
                },
                new SubOfSubCategory()
                {
                    Id = 6,
                    CategoryId = 8,
                    SubCategoryId = 4,
                    Title = "İçecek Şurubu",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 8,
                    SubCategoryId = 5,
                    Title = "Sıvı Yağlar",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 8,
                    SubCategoryId = 5,
                    Title = "Kahvaltılık",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 8,
                    SubCategoryId = 5,
                    Title = "Organik Gıda",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 8,
                    SubCategoryId = 5,
                    Title = "Gurme ürünler",
                },
                new SubOfSubCategory()
                {
                    Id = 5,
                    CategoryId = 8,
                    SubCategoryId = 5,
                    Title = "Aktar Ürünler",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 8,
                    SubCategoryId = 6,
                    Title = "Baharat",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 8,
                    SubCategoryId = 6,
                    Title = "Bakliyatlar",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 8,
                    SubCategoryId = 6,
                    Title = "Makarna",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 8,
                    SubCategoryId = 6,
                    Title = "Çorba",
                },
                new SubOfSubCategory()
                {
                    Id = 5,
                    CategoryId = 8,
                    SubCategoryId = 6,
                    Title = "Şeker",
                },
                new SubOfSubCategory()
                {
                    Id = 6,
                    CategoryId = 8,
                    SubCategoryId = 6,
                    Title = "Tuz",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 9,
                    SubCategoryId = 1,
                    Title = "Oto İç Aksesuar",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 9,
                    SubCategoryId = 1,
                    Title = "Oto Dış Aksesuar",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 9,
                    SubCategoryId = 1,
                    Title = "Silecekler",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 9,
                    SubCategoryId = 1,
                    Title = "Oto Brandlar",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 9,
                    SubCategoryId = 2,
                    Title = "Oto Ses Sistemleri",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 9,
                    SubCategoryId = 2,
                    Title = "Oto Görüntü Sistemleri",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 9,
                    SubCategoryId = 2,
                    Title = "Navigasyon",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 9,
                    SubCategoryId = 3,
                    Title = "Oto Lastik",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 9,
                    SubCategoryId = 3,
                    Title = "Jant",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 9,
                    SubCategoryId = 4,
                    Title = "Oto Yedek Parça",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 9,
                    SubCategoryId = 4,
                    Title = "Oto Bakım Ürünleri",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 9,
                    SubCategoryId = 4,
                    Title = "Akü Ve Aksesuarları",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 9,
                    SubCategoryId = 5,
                    Title = "Spor Yay,Amortisör Ve Coilver",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 9,
                    SubCategoryId = 5,
                    Title = "Eksoz",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 9,
                    SubCategoryId = 5,
                    Title = "Pedal Seti",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 9,
                    SubCategoryId = 5,
                    Title = "Vites Topuzu Ve Direksiyon",
                },
                new SubOfSubCategory()
                {
                    Id = 5,
                    CategoryId = 9,
                    SubCategoryId = 5,
                    Title = "Göstergeler",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 9,
                    SubCategoryId = 6,
                    Title = "Motorsikletler",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 9,
                    SubCategoryId = 6,
                    Title = "Utv",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 9,
                    SubCategoryId = 6,
                    Title = "Atv",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 9,
                    SubCategoryId = 6,
                    Title = "Motosiklet Aksesuarları",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 9,
                    SubCategoryId = 6,
                    Title = "Motosiklet Lastikleri",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 9,
                    SubCategoryId = 7,
                    Title = "Basamaklar",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 9,
                    SubCategoryId = 7,
                    Title = "Çamurluk Dodik",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 9,
                    SubCategoryId = 7,
                    Title = "Kabin",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 9,
                    SubCategoryId = 7,
                    Title = "Ön Koruma",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 10,
                    SubCategoryId = 1,
                    Title = "Köpek Mama & Su Kapları",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 10,
                    SubCategoryId = 1,
                    Title = "Köpek Çiğneme Kemikleri",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 10,
                    SubCategoryId = 1,
                    Title = "Köpek Tasmaları",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 10,
                    SubCategoryId = 1,
                    Title = "Köpek Taşıma & Seyahat Ürünleri",
                },
                new SubOfSubCategory()
                {
                    Id = 5,
                    CategoryId = 10,
                    SubCategoryId = 1,
                    Title = "Köpek Oyuncakları",
                },
                new SubOfSubCategory()
                {
                    Id = 6,
                    CategoryId = 10,
                    SubCategoryId = 1,
                    Title = "Köpek Elbiseleri",
                },
                new SubOfSubCategory()
                {
                    Id = 7,
                    CategoryId = 10,
                    SubCategoryId = 1,
                    Title = "Köpek Yatakları",
                },
                new SubOfSubCategory()
                {
                    Id = 8,
                    CategoryId = 10,
                    SubCategoryId = 1,
                    Title = "Köpek Kulübeleri",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 10,
                    SubCategoryId = 2,
                    Title = "Kedi Mama & Su Kapları",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 10,
                    SubCategoryId = 2,
                    Title = "Kedi Kumları",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 10,
                    SubCategoryId = 2,
                    Title = "Kedi Tuvalet Kabı & Aksesuarları",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 10,
                    SubCategoryId = 2,
                    Title = "Kedi Tasmaları",
                },
                new SubOfSubCategory()
                {
                    Id = 5,
                    CategoryId = 10,
                    SubCategoryId = 2,
                    Title = "Kedi Taşıma & Seyahat Ürünleri",
                },
                new SubOfSubCategory()
                {
                    Id = 6,
                    CategoryId = 10,
                    SubCategoryId = 2,
                    Title = "Kedi Oyuncakları",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 10,
                    SubCategoryId = 3,
                    Title = "Kuş Kafesleri & Aksesuarları",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 10,
                    SubCategoryId = 3,
                    Title = "Kuş Yemleri & Kraterler",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 10,
                    SubCategoryId = 3,
                    Title = "Kuş Sulluk & Yemlikleri",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 10,
                    SubCategoryId = 3,
                    Title = "Kuş Oyuncak & Tünekleri",
                },
                new SubOfSubCategory()
                {
                    Id = 5,
                    CategoryId = 10,
                    SubCategoryId = 3,
                    Title = "Kuş Sağlık ve Bakım Ürünleri",
                },
                new SubOfSubCategory()
                {
                    Id = 6,
                    CategoryId = 10,
                    SubCategoryId = 3,
                    Title = "Kuluçka Makineleri",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 10,
                    SubCategoryId = 4,
                    Title = "Akvaryum",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 10,
                    SubCategoryId = 4,
                    Title = "Akvaryum Malzemeleri",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 10,
                    SubCategoryId = 4,
                    Title = "Dekoratif Malzemeler",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 10,
                    SubCategoryId = 4,
                    Title = "Filtreler",
                },
                new SubOfSubCategory()
                {
                    Id = 5,
                    CategoryId = 10,
                    SubCategoryId = 4,
                    Title = "Filtre Malzemeleri",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 10,
                    SubCategoryId = 5,
                    Title = "Yemler / Ek Besinler",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 10,
                    SubCategoryId = 5,
                    Title = "Kafesler",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 10,
                    SubCategoryId = 5,
                    Title = "Oyuncaklar",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 10,
                    SubCategoryId = 5,
                    Title = "Bakım / Temizlik Malzemeleri",
                },
                new SubOfSubCategory()
                {
                    Id = 5,
                    CategoryId = 10,
                    SubCategoryId = 5,
                    Title = "Yataklar / Evler",
                },
                new SubOfSubCategory()
                {
                    Id = 6,
                    CategoryId = 10,
                    SubCategoryId = 5,
                    Title = "Kafesler / Oyun Parkı",
                },
                new SubOfSubCategory()
                {
                    Id = 7,
                    CategoryId = 10,
                    SubCategoryId = 5,
                    Title = "Mama Kapları Suluk / Beslenme Aparatları",
                },
                new SubOfSubCategory()
                {
                    Id = 8,
                    CategoryId = 10,
                    SubCategoryId = 5,
                    Title = "Derece / Nem Ölçerler",
                },
                new SubOfSubCategory()
                {
                    Id = 1,
                    CategoryId = 10,
                    SubCategoryId = 6,
                    Title = "Yemler / Ek Besinler",
                },
                new SubOfSubCategory()
                {
                    Id = 2,
                    CategoryId = 10,
                    SubCategoryId = 6,
                    Title = "Terearyumlar / Malzemeler",
                },
                new SubOfSubCategory()
                {
                    Id = 3,
                    CategoryId = 10,
                    SubCategoryId = 6,
                    Title = "Aydınlatma / Uv / Ay Işığı / Isıtma Malzemelri",
                },
                new SubOfSubCategory()
                {
                    Id = 4,
                    CategoryId = 10,
                    SubCategoryId = 6,
                    Title = "Kaplumbağa Bahçeleri ve Aksesuarları",
                }
    };

        public List<SubCategory> GetBabyPopulerCategories()
        {
            throw new System.NotImplementedException();
        }

        public List<SubCategory> GetElektronicPopulerCategories()
        {
            throw new System.NotImplementedException();
        }

        public List<MainCategory> GetMainCategories()
        {
            return MainCategories;
        }

        public List<SubCategory> GetSubCategories()
        {
            return SubCategories;
        }

        public List<SubCategory> GetSubCategories(MainCategory mainCategory)
        {
            throw new System.NotImplementedException();
        }

        public List<SubOfSubCategory> GetSubOfSubCategories()
        {
            return SubOfSubCategories;
        }

        public List<SubOfSubCategory> GetSubOfSubCategories(SubCategory subCategory)
        {
            throw new System.NotImplementedException();
        }
    }
}
