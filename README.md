# Reverse-Polish-Notation-with-c#
<h5>C# dilinde Temel Nesne Tabanlı Programlama prensipleri kullanılarak stack veri yapılarıyla oluşturulan girilen sayıları hesaplayarak kullanıcıya veren algoritma.
</h5>
<h4> Algoritmanın temel akış şekli:<br><br>
Adım 1- Sayılar operatör gelene dek stack’e atılır.<br>
Adım 2-Stack'ten iki sayı pop edilir.<br>
Adım 3-İşlem yapılır.<br>
Adım 4-Sonuç tekrar stack’e push edilir.<br>
Adım 5-Eğer başka sayı varsa adım 1' e gidilir yoksa algoritma sonlanır.<br><br>
</h4>
<H3>ÖRNEK:<H3>

<h4> 3 4 + = (3+4) </h4>
<h4> 3 4 + 5 6 + . = (3+4) . (5+6) </h4>
<h4> 5 3 3 - / = (0 'a bölme hatası yaptınız) </h4>
<h4> 15 7 1 1 + - / 3 * 2 1 1 + + - =  (15 / (7 - (1 + 1))) * 3 ) - (2 + (1 + 1) </h4>
