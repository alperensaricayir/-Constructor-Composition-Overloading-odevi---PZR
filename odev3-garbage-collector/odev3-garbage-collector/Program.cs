//using System;

//**C#’ta Garbage Collector Nedir?**

//* *1.Garbage Collector(Çöp Toplayıcı) Nedir?**
//Garbage Collector (GC), C# ve .NET platformunda bellek yönetimini otomatik olarak gerçekleştiren bir mekanizmadır. Kullanılmayan nesneleri bellekten temizleyerek bellek sızıntılarını önler ve uygulamanın performansını artırır.

//**2. Nasıl Çalışır?**
//C#’ta nesneler Heap (Yığın) bellekte oluşturulur. GC, belirli aralıklarla çalışarak erişilemeyen nesneleri tespit eder ve belleği temizler. İşleyişi şu adımlarla gerçekleşir:
//   - **Root Analysis:**Uygulama tarafından hala erişilen nesneler belirlenir.
//   - **Marking:**Kullanılmayan nesneler işaretlenir.
//   -**Sweeping:**İşaretlenen nesneler bellekten kaldırılır.
//   - **Compacting:**Bellek boşlukları düzenlenerek parçalanma önlenir.

//**3. Nesne Ömrü ve GC Jenerasyonları**
//GC, nesneleri üç jenerasyona (Generation 0, 1 ve 2) ayırır:
//   -**Generation 0:**Yeni oluşturulan nesneler buraya yerleştirilir. Çöp toplama sık gerçekleşir.
//   - **Generation 1:**GC tarafından kısa süre önce temizlenen ama hala kullanılan nesneler burada tutulur.
//   - **Generation 2:**Uzun ömürlü nesneler burada saklanır. Temizleme işlemi daha az sıklıkla yapılır.

//**4. GC Manuel Çalıştırma**
//GC otomatik olarak çalışsa da, gerektiğinde manuel olarak çağrılabilir:
//```csharp
//GC.Collect();
//GC.WaitForPendingFinalizers();
//```
//Ancak, manuel çağrım genellikle önerilmez çünkü performans sorunlarına yol açabilir.

//**5. Garbage Collector’ın Avantajları**
//   - Bellek sızıntılarını önler.
//   - Programcının manuel bellek yönetimi yapmasını gerektirmez.
//   - Otomatik çalışarak performans optimizasyonu sağlar.

//**Sonuç**
//C#’ta Garbage Collector, bellek yönetimini kolaylaştırarak güvenilir ve verimli bir uygulama geliştirmeye yardımcı olur. Ancak, GC’nin nasıl çalıştığını anlamak ve gereksiz nesne oluşturmayı önlemek, performansı artırmak açısından önemlidir.

