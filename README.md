# MVC’de Action Metotlar Nedir?
MVC (Model-View-Controller) tasarım deseni, kullanıcı arayüzü, iş mantığı ve veri erişimini birbirinden ayırmayı amaçlayan bir yazılım mimarisidir. 
Bu mimaride Controller bileşeni, gelen istekleri (HTTP isteklerini) işler ve uygun bir yanıt döner. 
Controller içinde bulunan Action Metotlar, bu istekleri karşılayan ve gerekli işlevleri gerçekleştiren temel bileşenlerdir

Action Metot Nedir?
<br>
Action metotlar, bir Controller sınıfında tanımlanan ve bir HTTP isteğine (GET, POST, PUT, DELETE vb.) karşılık gelen iş mantığını yürüten özel metotlardır. 
Her bir Action metot, istemciden gelen isteklere yanıt verir ve genellikle bir View döner veya başka bir işlevsel yanıt oluşturur.
