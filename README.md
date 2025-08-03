# Şehir Tanıtım Projesi

## Proje Hakkında
Bu proje, **Web ve Mobil Programlama** dersi kapsamında geliştirilmiş bir şehir tanıtım uygulamasıdır. Proje, hem web hem de mobil platformlarda şehirlerin tanıtımını yapan kapsamlı bir sistem içermektedir.

## Proje Özellikleri

### Genel Özellikler
- **Şehir Tanıtımı**: Şehirlerin genel bilgileri, tarihi, kültürü ve önemli yerlerinin tanıtımı
- **İlçe Yönetimi**: Şehirlere bağlı ilçelerin detaylı bilgileri
- **Mekan Yönetimi**: Turistik yerler, restoranlar, oteller gibi önemli mekanların bilgileri
- **Nüfus Bilgileri**: Şehir ve ilçelerin demografik verileri
- **Görsel Galeri**: Şehirle ilgili fotoğraf ve görsellerin sergilenmesi
- **Admin Paneli**: İçerik yönetimi için admin arayüzü

### Web Uygulaması Özellikleri
- **Kullanıcı Yönetimi**: Kayıt olma, giriş yapma ve profil yönetimi
- **İçerik Yönetimi**: Admin paneli üzerinden şehir, ilçe, mekan bilgilerinin yönetimi
- **Responsive Tasarım**: Tüm cihazlarda uyumlu çalışan arayüz
- **Güvenli Authentication**: ASP.NET Identity ile güvenli kullanıcı doğrulama

### Mobil Uygulaması Özellikleri
- **Native Android Uygulaması**: Java ile geliştirilmiş Android uygulaması
- **Kullanıcı Dostu Arayüz**: Modern ve sezgisel mobil arayüz
- **Offline Destek**: Temel bilgilere internet bağlantısı olmadan erişim

## Teknoloji Stack

### Web Uygulaması
- **Framework**: ASP.NET MVC 5
- **Backend Dili**: C# (.NET Framework 4.8)
- **Veritabanı**: Entity Framework 6.4.4 (Code First)
- **Frontend**: 
  - HTML5, CSS3, JavaScript
  - Bootstrap 5.2.3
  - jQuery 3.4.1
  - jQuery Validation 1.17.0
- **Authentication**: ASP.NET Identity 2.2.4
- **Güvenlik**: OWIN 4.2.2
- **JSON İşleme**: Newtonsoft.Json 12.0.2
- **Build Tool**: MSBuild
- **IDE**: Visual Studio

### Mobil Uygulaması
- **Platform**: Android (Java)
- **Minimum SDK**: API 24 (Android 7.0)
- **Target SDK**: API 33 (Android 13)
- **Build Tool**: Gradle
- **IDE**: Android Studio
- **Test Framework**: AndroidJUnit

### Geliştirme Araçları
- **Version Control**: Git
- **Package Managers**: 
  - NuGet (Web)
  - Gradle (Android)
- **Web Server**: IIS Express

## Proje Yapısı

```
Sehir-Tanitimi/
├── web/                    # Web uygulaması
│   └── SehirProje/
│       ├── SehirProje.sln  # Visual Studio Solution
│       └── SehirProje/     # ASP.NET MVC Projesi
│           ├── Controllers/ # MVC Controllers
│           ├── Models/      # Entity Framework Models
│           ├── Views/       # Razor Views
│           ├── Content/     # CSS ve statik dosyalar
│           └── Scripts/     # JavaScript dosyaları
└── mobil/                  # Mobil uygulama
    └── SehirTanitim/       # Android Studio Projesi
        └── app/
            └── src/main/java/ # Java kaynak kodları
```

## Kurulum ve Çalıştırma

### Web Uygulaması
1. Visual Studio'yu açın
2. `web/SehirProje/SehirProje.sln` dosyasını açın
3. NuGet paketlerini restore edin
4. Veritabanı bağlantısını `Web.config` dosyasından yapılandırın
5. F5 ile uygulamayı çalıştırın

### Mobil Uygulaması
1. Android Studio'yu açın
2. `mobil/SehirTanitim` klasörünü proje olarak açın
3. Gradle sync işlemini tamamlayın
4. Android emulator veya gerçek cihazda uygulamayı çalıştırın

## Ders Bilgileri
- **Ders**: Web ve Mobil Programlama
- **Proje Türü**: Dönem Ödevi
- **Platform**: Hibrit (Web + Mobil)
