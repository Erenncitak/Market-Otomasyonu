create proc login_sp
(
@kullaniciAdi varchar(50),
@sifre varchar(30)
)
as
begin
	select count(*) from loginTable where kullaniciAdi=@kullaniciAdi and sifre=@sifre
end

select count(*) from loginTable where kullaniciAdi='eren' and sifre='111'

select * from loginTable

update loginTable set guvenlikCevabi='köpek' where id=1
update loginTable set guvenlikCevabi='audi' where id=2

create proc guvenlikSorusuGetir_sp
as
begin
	select * from loginTable
end

create proc herhangibirisim_sp
as
begin
	select guvenlikSorusu from loginTable
end

create proc sifreGuncelle_sp
(
@kullaniciAdi varchar(50),
@sifre varchar(30)
)
as
begin
	update loginTable set sifre=@sifre where kullaniciAdi=@kullaniciAdi
end

alter table loginTable add constraint unieque_user unique (kullaniciAdi)

sp_help 'loginTable'

alter table urun add constraint unieque_barkod unique (barkodKod)


create proc sp_kullaniciEkle
(
@kullaniciAdi varchar(50),
@sifre varchar(50),
@yetki varchar(20),
@bolge varchar(50),
@emailAdres varchar(100),
@guvenlikSorusu varchar(200),
@guvenlikCevabi varchar(70)
)
as
begin
	insert into loginTable (kullaniciAdi,sifre,yetki,bolge,emailAdres,guvenlikSorusu,guvenlikCevabi) 
	values(@kullaniciAdi,@sifre,@yetki,@bolge,@emailAdres,@guvenlikSorusu,@guvenlikCevabi)
end


create proc sp_kullaniciGuncelle
(
@id varchar(50),
@kullaniciAdi varchar(50),
@sifre varchar(50),
@yetki varchar(20),
@bolge varchar(50),
@emailAdres varchar(100),
@guvenlikSorusu varchar(200),
@guvenlikCevabi varchar(70)
)
as
begin
	update loginTable set 
	kullaniciAdi=@kullaniciAdi,
	sifre=@sifre,
	yetki=@yetki,
	bolge=@bolge,
	emailAdres=@emailAdres,
	guvenlikSorusu=@guvenlikSorusu,
	guvenlikCevabi=@guvenlikCevabi
	where id=@id
end

create proc sp_kullaniciSil
(
@id varchar()
)
as
begin
delete from loginTable where id=@id
end

create proc sp_urunEkle
(
@id varchar(10),
@qrkod varchar(50),
@barkodKod varchar(50),
@olusturulma_Tarih datetime,
@guncellenme_Tarih datetime,
@urunIsim varchar(50),
@kilo int,
@fiyat int,
@ciro int
)
as
begin
	insert into urun values(@id,@qrkod,@barkodKod,@olusturulma_Tarih,@guncellenme_Tarih,@urunIsim,@kilo,@fiyat,@ciro)
end


create proc sp_urunGuncelle
(
@id varchar(10),
@qrkod varchar(50),
@barkodKod varchar(50),
@olusturulma_Tarih datetime,
@guncellenme_Tarih datetime,
@urunIsim varchar(50),
@kilo int,
@fiyat int,
@ciro int
)
as
begin
	update urun set qrkod=@qrkod,barkodKod=@barkodKod,olusturulma_Tarih=@olusturulma_Tarih,guncellenme_Tarih=@guncellenme_Tarih,
	urunIsim=@urunIsim,kilo=@kilo,fiyat=@fiyat,ciro=@ciro
	where id=@id
end