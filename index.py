import random
iller = ['adana','bursa','çanakkale','tekirdağ','izmir']
iller_bagil = iller

askerler = ['yusuf','yiğit','talha','zeynep','yunus','emre']
askerler_bagil = askerler

sonuclar = []

for i in range(0,len(iller_bagil)):
    rastgele = random.randint(0,len(askerler_bagil)-1)
    print(rastgele)
    sonuclar.append(askerler[rastgele]+"/"+iller_bagil[0])
    iller_bagil.pop(0)
    askerler_bagil.pop(0) #sürekli ilk elemanı siler (eğer ilk elemanı silerseniz 2.eleman ilk eleman olur bu sayede sürekli silme işlemi yaparsınız eğer bunu for ile yapsaydık index range hatası alıcaktık)
print(sonuclar)
print(iller_bagil)