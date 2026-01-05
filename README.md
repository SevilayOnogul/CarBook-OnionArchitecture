# 🚗 CarBook Projesi

Bu proje, modern yazılım mimarileri ve tasarım desenleri kullanılarak geliştirilmiş, ölçeklenebilir ve kurumsal mimariye uygun bir araç kiralama sistemidir.

### 🏗️ Kullanılan Teknolojiler & Mimari
* **Onion Architecture:** Proje; Core, Application, Persistence ve Infrastructure olmak üzere 4 ana katmandan oluşur.
* **CQRS Design Pattern:** Veri yazma (Command) ve veri okuma (Query) sorumlulukları birbirinden ayrılmıştır.
* **MediatR:** Katmanlar arası iletişimi merkezi bir yapı üzerinden sağlayarak bağımlılıkları (coupling) minimize eder.
* **ASP.NET Core 8.0:** Modern Web API ve WebUI entegrasyonu.
* **Entity Framework Core:** Veritabanı yönetim ve sorgulama işlemleri için ORM kullanımı.
* **DTO (Data Transfer Object):** Veri taşıma süreçlerinde güvenlik ve performans optimizasyonu.

---

### 🛠️ Tamamlanan Özellikler (Milestones)

#### 1. Blog & Yorum Sistemi
* **Dinamik Blog Yönetimi:** Blog içerikleri ve detay sayfaları API üzerinden dinamik olarak yönetiliyor.
* **Letter Avatars:** Resim yüklemeyen kullanıcılar için isim baş harflerinden otomatik dairesel avatar oluşturan özel C# mantığı geliştirildi.
* **Tarih Formatlama:** Yorum ve blog tarihleri kullanıcı dostu (dd-MMM-yyyy) formatına getirildi.

#### 2. Kullanıcı Deneyimi (UI/UX)
* **SweetAlert2 Entegrasyonu:** Klasik uyarı kutuları yerine modern, şık ve interaktif modal pencereler sisteme dahil edildi.
* **Interaktif Footer:** Alt menüdeki "Nasıl Çalışır", "Koşullar" gibi bilgilendirme alanları SweetAlert2 ile dinamik hale getirildi.
* **CSS Optimizasyonu:** Avatar hizalamaları ve form kontrolleri için özel stil giydirmeleri yapıldı.

#### 3. Admin Paneli & Araç Yönetimi
* **Araç Özellik Yönetimi:** Araçlara ait donanımların (Klima, ABS, Otomatik Vites vb.) aktif/pasif edilebildiği dinamik listeleme yapısı kuruldu.
* **Advanced Model Binding:** Çoklu veri girişini (`for` loop ve indeksleme kullanarak) destekleyen kompleks form yapıları geliştirildi.
* **CRUD İşlemleri:** Araç, marka, kategori ve blog yönetimi için tam fonksiyonel yönetim paneli.

---

### 🚀 Proje Kurulumu
1. Bu depoyu klonlayın: `git clone https://github.com/kullaniciadi/carbook.git`
2. `appsettings.json` dosyasındaki **Connection String** bilgisini kendi SQL Server adresinizle güncelleyin.
3. Package Manager Console üzerinden `Update-Database` komutunu çalıştırarak tabloları oluşturun.
4. Önce **Web API** projesini, ardından **WebUI** projesini çalıştırın.


