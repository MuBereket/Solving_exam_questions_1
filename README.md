# Solving_exam_questions_1
Soru-1-Bir mağazada, çikolata kutularından oluşan bir stack vardır ve her kutu pozitif sayıda çikolata içermektedir.
Başlangıçta stack boştur ve kapasitesi sınırsızdır. N dakika zaman geçtikten sonra aşağıdaki olaylardan herhangi ikisi gerçekleşebilir:
-Stack in en üstündeki çikolata kutusunun satılması.
-Depodan bir çikolata kutusu alınıp stack in en üstüne eklenmesi.
-Eğer C[i]=0 ise bir kutu çikolata satılıyor, C[i] > 0 ise içerisinde C[i] adet çikolata bulunan bir kutu alınıyor.
-Yalnızca stack in boş olmadığı durumda müşteri gelebilir.
Yukarıdaki koşulları sağlayan N ve C değerlerini parametre olarak alan, sonrasında toplamda satılan çikolataların sayısını geri döndüren uygulamayı Stack Sınıfını kullanarak yazınız.
Örneğin;
Giriş : N = 5 ve C={3,0, 2, 1, 4}
Çıkış : 3
Açıklama:
Başlangıçta yığın boş olduğu varsayılmaktadır.
1.       Dakikada, 3 adet çikolata bulunan bir kutu alınmaktadır ve yığının en üstüne eklenmektedir. Yığın: [3]
2.       Dakikada, Yığının en üstündeki çikolata kutusu(3 çikolata) satılmaktadır. Yığın: []
3.       Dakikada, 2 adet çikolata bulunan bir kutu alınmaktadır ve yığının en üstüne eklenmektedir. Yığın: [2]
4.       Dakikada, 1 adet çikolata bulunan bir kutu alınmaktadır ve yığının en üstüne eklenmektedir. Yığın: [1, 2]
5.       Dakikada, 4 adet çikolata bulunan bir kutu alınmaktadır ve yığının en üstüne eklenmektedir. Yığın: [4, 1, 2]
Sonuç olarak sadece 3 adet çikolata barındıran ilk kutu satılmıştır. Bundan dolayı çıkış 3’ tür.
Soru-2-Bir fakültede birden fazla eğitimci ile çeşitli dersler veren bir bölüm bulunmaktadır. Her ders bir eğitmen tarafından verilmekte olup bir eğitmen birden fazla ders verebilmektedir.
a-Dersleri ve Eğitmenleri temsil etmek için aşağıdaki özellikleri barındıran Ders ve Egitmen sınıflarını oluşturunuz.
Ders = int ID, String ders_adı, int egitmen_ID
Egitmen = int ID, String egitmen_adı, Ders[] verilen_dersler
b-Bir eğitmene ders eklemek ve eğitmenin verdiği dersleri listelemek(max 20 ders listelenecek) için gerekli metotları yazınız.

Soru-3-Bir koordinat düzleminde A noktasını temsil etmek için x ve y ekseni konumları kullanılmaktadır. Herhangi bir noktayı saklayabilecek ve aşağıdaki işlemleri gerçekleştirebilecek metotları barındıran Points adında bir sınıf oluşturulmalı ve bu metotların testini gerçekleştiren bir metot yazınız.
a-Noktanın koordinatlarını atamak.
b-Noktanın koordinatlarını yazdırmak.
c-Noktanın x koordinatını geri döndürmek.
d-Noktanın y koordinatını geri döndürmek.

Soru-4-Bir polinom P(x)= x^4 + 2x^2 + 5 şeklinde yazılmakta olup x^4, 2x^2, 5 olmak üzere 3 terim ile ifade edilmektedir. Bu polinomun katsayıları 1, 2, ve 5 ‘tir. Kuvvetleri ise 4, 2 ve 1 ‘dir.
Bir Polinom nesnesi int toplam_terim_sayisi, int katsayılar (koleksiyon veya dizi) ve int kuvvetler (koleksiyon veya dizi) olmak üzere 3 özelliğe sahiptir. Örneğin;
P1= x^4 + 2x^2 + 5 = P1_toplam_terim_sayisi=3, P1_katsayılar={1, 2, 5}, P1_kuvvetler={4, 2, 1}.
P2= 3x^3 + 6 = P2_toplam_terim_sayisi=2, P2_katsayılar={3, 6}, P2_kuvvetler={3, 1}.
a-Yukarıda belirtilen özelliklere sahip polinom nesnesi oluşturan sınıfı ve yapılandırıcı metodu yazınız.
b-Parametre olarak bir polinom nesnesi alan ve polinom nesnesini denklem olarak ekrana yazan methodu yazınız. polinom_yaz(P) = x^4 + 2x^2 + 5
***c ve d şıkları için polinom_kontrol metodu overloading edilerek kullanılmalıdır.
c-Parametre olarak polinom alan ve polinomun sıfır olup olmadığını kontrol eden bir method yazınız.(P==0, katsayı, sabit ve kuvvetlerin 0 olması durumu) polinom_kontrol(P)
d-Parametre olarak iki polinom nesnesi alan ve bu polinomların eşitliğini kontrol eden bir method yazınız. (P1==P2) polinom_kontrol(P1,P2)
e- Parametre olarak polinom ve bir int n değeri alan ve polinomun katsayılarını n kadar artıran bir mothod yazınız. f1(P= x^4 + 2x^2 + 5, n=2) -> yeni_ P= 2x^4 + 4x^2 + 7
f- Parametre olarak polinom ve bir int n değeri alan ve polinomun sabit değerini n kadar artıran bir mothod yazınız. f2(P= x^4 + 2x^2 + 5, n=8) -> yeni_ P= x^4 + 2x^2 + 13
 
