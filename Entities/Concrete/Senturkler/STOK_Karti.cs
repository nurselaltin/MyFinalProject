﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.Senturkler
{
    using System;
    using System.Collections.Generic;

    public partial class STOK_Karti:IEntity
    {
        public short IptDrm { get; set; }
        public int Stok_No { get; set; }
        public string Stok_Kodu { get; set; }
        public string Adi_1 { get; set; }
        public string Adi_2 { get; set; }
        public string Kisa_Adi { get; set; }
        public Nullable<byte> Cinsi { get; set; }
        public Nullable<short> Durum { get; set; }
        public string Grup_Kodu { get; set; }
        public string Ozel_Kodu { get; set; }
        public string Orjinal_Kodu { get; set; }
        public string GTIP_Kodu { get; set; }
        public string Uretici_Kodu { get; set; }
        public string Ambalaj_Kodu { get; set; }
        public string Malzeme_Kodu { get; set; }
        public string Sektor_Kodu { get; set; }
        public string Reyon_Kodu { get; set; }
        public Nullable<int> Kar_Orani { get; set; }
        public Nullable<int> Kom_Orani { get; set; }
        public Nullable<short> KDV_T { get; set; }
        public Nullable<short> KDV_P { get; set; }
        public Nullable<short> Alis_Vade_Gunu { get; set; }
        public Nullable<short> Satis_Vade_Gunu { get; set; }
        public Nullable<int> Max_Miktar { get; set; }
        public Nullable<int> Min_Miktar { get; set; }
        public Nullable<short> Raf_Omru { get; set; }
        public Nullable<short> Departman_No { get; set; }
        public string Sezon { get; set; }
        public string Saglayan_Cari { get; set; }
        public string Ruhsat_Sahibi { get; set; }
        public Nullable<System.DateTime> Ruhsat_Tarihi { get; set; }
        public string Ruhsat_No { get; set; }
        public string Ana_Stok { get; set; }
        public string Yetki_Kodu { get; set; }
        public string Acilis_User { get; set; }
        public string Update_User { get; set; }
        public string Iptal_User { get; set; }
        public Nullable<System.DateTime> Acilis_Zaman { get; set; }
        public Nullable<System.DateTime> Update_Zaman { get; set; }
        public Nullable<System.DateTime> Iptal_Zaman { get; set; }
        public string Notlar { get; set; }
        public string Resim { get; set; }
        public Nullable<double> Temin_Maliyeti { get; set; }
        public Nullable<double> Satis_Masrafi { get; set; }
        public Nullable<double> Temin_Masrafi { get; set; }
        public Nullable<byte> Per_Satis_Tipi { get; set; }
        public Nullable<double> Fire_Orani { get; set; }
        public string Ana_Stok2 { get; set; }
        public string Ana_Stok3 { get; set; }
        public Nullable<double> Ana_Oran { get; set; }
        public Nullable<double> Ana_Oran2 { get; set; }
        public Nullable<double> Ana_Oran3 { get; set; }
        public string Ozel_Kodu1 { get; set; }
        public string Ozel_Kodu2 { get; set; }
        public string Ozel_Kodu3 { get; set; }
        public string Ozel_Kodu4 { get; set; }
        public string Ozel_Kodu5 { get; set; }
        public string Ozel_Kodu6 { get; set; }
        public string Ozel_Kodu7 { get; set; }
        public string Ozel_Kodu8 { get; set; }
        public string Ozel_Kodu9 { get; set; }
        public string Ozel_Kodu10 { get; set; }
        public Nullable<byte> Kilit { get; set; }
        public string Satici_Kodu { get; set; }
        public Nullable<byte> Sip_Sekli { get; set; }
        public Nullable<int> Sip_Depo { get; set; }
        public Nullable<short> Ent_Kodu { get; set; }
        public Nullable<double> Puani { get; set; }
        public Nullable<byte> Indirim_Yok { get; set; }
        public Nullable<byte> Puan_Yok { get; set; }
        public string Ozel_Kodu11 { get; set; }
        public string Ozel_Kodu12 { get; set; }
        public string Ozel_Kodu13 { get; set; }
        public string Ozel_Kodu14 { get; set; }
        public string Ozel_Kodu15 { get; set; }
        public string Icerik_Bilgisi { get; set; }
        public string Alerjen_Bilgisi { get; set; }
        public string Gida_Uretim_Izni { get; set; }
    }
}


//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------




