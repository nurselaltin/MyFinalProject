//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace test.Concrete
{
    using System;
    using System.Collections.Generic;
    
    public partial class FATR_Baslik
    {
        public short Fis_Durum { get; set; }
        public short Fis_Tipi { get; set; }
        public int Fis_No { get; set; }
        public short Isyeri_Kodu { get; set; }
        public Nullable<byte> Kilit { get; set; }
        public Nullable<System.DateTime> Fis_Tarihi { get; set; }
        public Nullable<short> Depo_Kodu { get; set; }
        public string Kasa_Kodu { get; set; }
        public Nullable<int> Cari_No { get; set; }
        public string Belge_No { get; set; }
        public Nullable<System.DateTime> Belge_Tarihi { get; set; }
        public string Fat_No { get; set; }
        public Nullable<byte> Cari_Kayit { get; set; }
        public Nullable<byte> Kasa_Kayit { get; set; }
        public Nullable<short> Islem_Tipi1 { get; set; }
        public Nullable<short> Islem_Tipi2 { get; set; }
        public Nullable<int> Kdv_Tipi1 { get; set; }
        public Nullable<int> Kdv_Tipi2 { get; set; }
        public Nullable<short> EkV_Tipi { get; set; }
        public Nullable<short> EkV_Orani { get; set; }
        public string Fiyat_Tipi { get; set; }
        public Nullable<short> Maliyet_Tipi { get; set; }
        public Nullable<short> Odeme_Tipi { get; set; }
        public string Odeme_Kodu { get; set; }
        public Nullable<short> Odeme_Sekli { get; set; }
        public Nullable<System.DateTime> Odeme_Vadesi { get; set; }
        public Nullable<short> Isk_Hesap_Sekli { get; set; }
        public Nullable<short> Isk_Hesap_Tipi { get; set; }
        public Nullable<short> Isk_Kademe_Tipi { get; set; }
        public string Para_Birimi { get; set; }
        public Nullable<double> Kur_Degeri { get; set; }
        public Nullable<double> TopDeger1 { get; set; }
        public Nullable<double> TopDeger2 { get; set; }
        public Nullable<double> TopIskonto1 { get; set; }
        public Nullable<double> TopIskonto2 { get; set; }
        public Nullable<double> TopMasraf1 { get; set; }
        public Nullable<double> TopMasraf2 { get; set; }
        public Nullable<double> ToplamKdv { get; set; }
        public Nullable<double> ToplamEkV { get; set; }
        public Nullable<double> NetTutar1 { get; set; }
        public Nullable<double> NetTutar2 { get; set; }
        public string Ilgili_Kisi { get; set; }
        public string Aciklama { get; set; }
        public string Yetki_Kodu { get; set; }
        public string Ozel_Kodu { get; set; }
        public string Odeme_Plani { get; set; }
        public string Satici_Kodu1 { get; set; }
        public string Satici_Kodu2 { get; set; }
        public string Ent_Kodu1 { get; set; }
        public Nullable<short> Ent_Fis_Tipi1 { get; set; }
        public Nullable<int> Ent_Fis_No1 { get; set; }
        public string Ent_Kodu2 { get; set; }
        public Nullable<short> Ent_Fis_Tipi2 { get; set; }
        public Nullable<int> Ent_Fis_No2 { get; set; }
        public string PF_Musteri { get; set; }
        public string PF_Adresi { get; set; }
        public string PF_IlceIl { get; set; }
        public string PF_Tel { get; set; }
        public string PF_VDaire { get; set; }
        public string PF_VergiNo { get; set; }
        public string Acilis_User { get; set; }
        public string Update_User { get; set; }
        public string Iptal_User { get; set; }
        public Nullable<System.DateTime> Acilis_Zaman { get; set; }
        public Nullable<System.DateTime> Update_Zaman { get; set; }
        public Nullable<System.DateTime> Iptal_Zaman { get; set; }
        public Nullable<System.DateTime> Vade_Tarihi { get; set; }
        public Nullable<int> Sirkuler_No { get; set; }
        public string OzelParaBirimi { get; set; }
        public Nullable<double> OzelIslem_Kuru { get; set; }
        public string Irs_No { get; set; }
        public Nullable<short> Iade_FisTipi { get; set; }
        public Nullable<int> Iade_FisNo { get; set; }
        public Nullable<int> K_Sip_No { get; set; }
        public Nullable<int> Sip_No { get; set; }
        public Nullable<int> Paket_Sayisi { get; set; }
        public string Paket_Aciklama { get; set; }
        public Nullable<double> GIskOrn1 { get; set; }
        public Nullable<double> GIskOrn2 { get; set; }
        public Nullable<double> GIskOrn3 { get; set; }
        public Nullable<double> GIskTut1 { get; set; }
        public Nullable<double> GIskTut2 { get; set; }
        public Nullable<double> GIskTut3 { get; set; }
        public Nullable<double> GIskTop { get; set; }
        public string Belge_Tipi { get; set; }
        public string Aciklama1 { get; set; }
        public string Masraf_Yeri { get; set; }
        public Nullable<byte> MuhEnt_Acik { get; set; }
        public Nullable<byte> Tevkifat_Tipi { get; set; }
        public Nullable<double> Tevkifat_Tutari { get; set; }
        public Nullable<double> Stopaj_Orani { get; set; }
        public Nullable<double> Stopaj_Tutari { get; set; }
        public Nullable<double> Tevkifat_Tutari2 { get; set; }
        public Nullable<double> Stopaj_Tutari2 { get; set; }
        public Nullable<byte> Kdv_EntTipi { get; set; }
        public Nullable<byte> Adres_SiraNo { get; set; }
        public Nullable<double> FF_Tutari { get; set; }
        public Nullable<double> GD_IskTut1 { get; set; }
        public Nullable<double> GD_IskTut2 { get; set; }
        public Nullable<double> GD_IskTut3 { get; set; }
        public Nullable<double> GD_IskTut4 { get; set; }
        public Nullable<double> GD_IskTut5 { get; set; }
        public Nullable<double> GD_IskTut6 { get; set; }
        public Nullable<double> GD_GDTut1 { get; set; }
        public Nullable<double> GD_GDTut2 { get; set; }
        public Nullable<double> GD_DnmTut1 { get; set; }
        public Nullable<double> GD_DnmTut2 { get; set; }
        public Nullable<double> GD_DnmTut3 { get; set; }
        public string Sirku_Nolar { get; set; }
        public string OzelParaBirimi2 { get; set; }
        public Nullable<double> OzelIslem_Kuru2 { get; set; }
        public Nullable<double> OzelCapraz_Kur { get; set; }
        public Nullable<short> FF_Fis_Tipi { get; set; }
        public Nullable<int> FF_Fis_No { get; set; }
        public Nullable<byte> Kontrol_Kodu { get; set; }
        public string Referans1 { get; set; }
        public string Referans2 { get; set; }
        public Nullable<int> Iade_Nedeni { get; set; }
        public Nullable<double> Kes_Oran1 { get; set; }
        public Nullable<double> Kes_Oran2 { get; set; }
        public Nullable<double> Kes_Oran3 { get; set; }
        public Nullable<double> Kes_Tutar1 { get; set; }
        public Nullable<double> Kes_Tutar2 { get; set; }
        public Nullable<double> Kes_Tutar3 { get; set; }
        public string KK_Degerlendirme { get; set; }
        public Nullable<double> Damga_Orani { get; set; }
        public Nullable<double> Damga_Tutari { get; set; }
        public Nullable<double> Damga_Tutari2 { get; set; }
        public Nullable<int> TransactionID { get; set; }
        public Nullable<int> TransactionID_Ipt { get; set; }
        public string ORA_Proje_Kodu { get; set; }
        public Nullable<double> Belge_Kari { get; set; }
        public string E_Fatura_Guid { get; set; }
        public Nullable<long> E_Fatura_FisNo { get; set; }
        public string E_Fatura_Dosya { get; set; }
        public Nullable<byte> E_Fatura_Onay { get; set; }
        public string E_Fatura_Tipi { get; set; }
        public string E_Fatura_Zarf_Guid { get; set; }
        public Nullable<short> Fatura_Tipi { get; set; }
        public string Onay_User { get; set; }
        public Nullable<System.DateTime> Onay_Zaman { get; set; }
        public string PF_E_Posta { get; set; }
        public string Istisna_Kodu { get; set; }
        public string Sevk_Unvani { get; set; }
        public string Sevk_Adresi { get; set; }
        public string Sevk_IlceIl { get; set; }
        public string Sevk_Telefon { get; set; }
    }
}
