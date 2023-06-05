# Light-LOD-Unity
Bu kod, ışıkların uzaklık eşiklerine göre yoğunluğunu hesaplayarak ışık LOD (Level of Detail) efektini uygulayan bir bileşeni temsil eder. Bileşen, belirli bir hesaplama sıklığı aralığında çalışır ve kamera ile ışıklar arasındaki mesafeyi kullanarak ışık yoğunluğunu belirler.

Bileşenin özellikleri şunlardır:

lights: Ayarlanacak ışıkların referanslarını içeren bir dizi.
distanceThresholds: Işıkların yoğunluğunu hesaplamak için kullanılacak uzaklık eşiklerinin değerlerini içeren bir dizi.
intensities: Uzaklık eşiklerine göre ışık yoğunluğunu belirlemek için kullanılacak yoğunluk değerlerini içeren bir dizi.
calculationInterval: Hesaplama sıklığını belirleyen bir sayacın değeri. Her calculationInterval kadar frame geçtiğinde hesaplama yapılır.

"LightLOD" adlı bu araç, Unity oyun motorunda ışıkların uzaklık eşiklerine göre yoğunluğunu hesaplayarak ışık LOD efektini uygular. Işıkların yoğunlukları, kamera ile ışıklar arasındaki mesafe ve belirli eşik değerleri kullanılarak hesaplanır. Bu araç kullanarak oyununuzda ışıkların performansını optimize edebilir ve görsel kaliteyi iyileştirebilirsiniz.

Kullanımı : 

1. "Light LOD" adında boş bir obje oluşturun.
2. LightLOD scriptini bu objenin içine atın.
3. LOD yapmak istediğiniz ışıkları listenin içine atın.
4. Gerekli distance ve intensities değerlerini giriniz.
