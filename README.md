
# KairaCQRSMediator

ASP.NET Core **MVC** üzerinde kurgulanmış, **CQRS** ve **MediatR** desenlerini birlikte kullanan örnek proje.
Uygulama; **Category, Service, Testimonial, Brand** gibi varlıklar için “CQRS tarzı Handler” yapısı,
**Product, Subscriber, PhotoGallery, SocialMedia, ContactInfo** gibi varlıklar içinse **MediatR** ile **Command/Query** akışlarını barındırır.
Veri erişimi **EF Core** ve **Generic Repository** üzerinden yapılır. Yönetim ekranları **Areas/Admin** altında toplanmıştır.

---

## Öne Çıkan Özellikler

* **.NET 8 + MVC** uygulama iskeleti
* **CQRS**: `Features/CQRS` altında entity bazlı **Handlers/Commands/Queries/Results**
* **MediatR**: `Features/Mediator` altında **IRequest/IRequestHandler** tabanlı iş akışları
* **EF Core + SQL Server** ile kalıcı katman
* **Generic Repository** ile sade CRUD soyutlaması
* **Areas/Admin** ile yönetim ekranları, **ViewComponents** ile parçalı UI
* **FluentValidation** (paket mevcut) ve **AutoMapper** (paket mevcut) entegrasyon altyapısı
* **wwwroot** ve **Views** klasörleriyle hazır MVC görünüm yapısı

---

## Teknolojiler & NuGet Paketleri

* **Target Framework**: `net8.0`
* **MediatR**: `13.0.0`
* **EntityFrameworkCore.SqlServer**: `8.0.20`
* **EntityFrameworkCore.Tools**: `8.0.20`
* **FluentValidation.AspNetCore**: `11.3.1`
* **AutoMapper**: `14.0.0`
* **Microsoft.VisualStudio.Web.CodeGeneration.Design**: `8.0.7`

---

## Yönetim (Admin) Alanı

* **Areas/Admin/Controllers**:
  `CategoryController`, `ProductController`, `ServiceController`, `TestimonialController`,
  `BrandController`, `SubscriberController`, `PhotoGalleryController`,
  `SocialMediaController`, `ContactController`
* **Areas/Admin/ViewComponents**:
  Yönetim layout parçaları ve script/include bileşenleri
* Görünümler (Views) ilgili klasörler altında yer alır.

---

## Ekran Görüntüleri

### Ana Sayfa
<img width="1890" alt="localhost_7165_HomePage_HomePage (2)" src="https://github.com/user-attachments/assets/31e1a9fe-aaf2-4844-9228-e1ec3477603f" />


### Ürünler
---
<img width="1890" height="2003" alt="localhost_7165_Admin_Product_Index" src="https://github.com/user-attachments/assets/56e982f9-99dd-4dae-bfad-04cdeb60bfdc" />


