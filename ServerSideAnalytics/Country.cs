using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace ServerSideAnalytics
{
    public enum CountryCodeIso3
    {
        World,
        Abw,
        Afg,
        Ago,
        Aia,
        Ala,
        Alb,
        And,
        Are,
        Arg,
        Arm,
        Asm,
        Ata,
        Atf,
        Atg,
        Aus,
        Aut,
        Aze,
        Bdi,
        Bel,
        Ben,
        Bfa,
        Bgd,
        Bgr,
        Bhr,
        Bhs,
        Bih,
        Blm,
        Blr,
        Blz,
        Bmu,
        Bol,
        Bra,
        Brb,
        Brn,
        Btn,
        Bvt,
        Bwa,
        Caf,
        Can,
        Cck,
        Che,
        Chl,
        Chn,
        Civ,
        Cmr,
        Cod,
        Cog,
        Cok,
        Col,
        Com,
        Cpv,
        Cri,
        Cub,
        Cuw,
        Cxr,
        Cym,
        Cyp,
        Cze,
        Deu,
        Dji,
        Dma,
        Dnk,
        Dom,
        Dza,
        Ecu,
        Egy,
        Eri,
        Esh,
        Esp,
        Est,
        Eth,
        Fin,
        Fji,
        Flk,
        Fra,
        Fro,
        Fsm,
        Gab,
        Gbr,
        Geo,
        Ggy,
        Gha,
        Gib,
        Gin,
        Glp,
        Gmb,
        Gnb,
        Gnq,
        Grc,
        Grd,
        Grl,
        Gtm,
        Guf,
        Gum,
        Guy,
        Hkg,
        Hmd,
        Hnd,
        Hrv,
        Hti,
        Hun,
        Idn,
        Imn,
        Ind,
        Iot,
        Irl,
        Irn,
        Irq,
        Isl,
        Isr,
        Ita,
        Jam,
        Jey,
        Jor,
        Jpn,
        Kaz,
        Ken,
        Kgz,
        Khm,
        Kir,
        Kna,
        Kor,
        Kos,
        Kwt,
        Lao,
        Lbn,
        Lbr,
        Lby,
        Lca,
        Lie,
        Lka,
        Lso,
        Ltu,
        Lux,
        Lva,
        Mac,
        Maf,
        Mar,
        Mco,
        Mda,
        Mdg,
        Mdv,
        Mex,
        Mhl,
        Mkd,
        Mli,
        Mlt,
        Mmr,
        Mne,
        Mng,
        Mnp,
        Moz,
        Mrt,
        Msr,
        Mtq,
        Mus,
        Mwi,
        Mys,
        Myt,
        Nam,
        Ncl,
        Ner,
        Nfk,
        Nga,
        Nic,
        Niu,
        Nld,
        Nor,
        Npl,
        Nru,
        Nzl,
        Omn,
        Pak,
        Pan,
        Pcn,
        Per,
        Phl,
        Plw,
        Png,
        Pol,
        Pri,
        Prk,
        Prt,
        Pry,
        Pse,
        Pyf,
        Qat,
        Reu,
        Rou,
        Rus,
        Rwa,
        Sau,
        Sdn,
        Sen,
        Sgp,
        Sgs,
        Sjm,
        Slb,
        Sle,
        Slv,
        Smr,
        Som,
        Spm,
        Srb,
        Ssd,
        Stp,
        Sur,
        Svk,
        Svn,
        Swe,
        Swz,
        Sxm,
        Syc,
        Syr,
        Tca,
        Tcd,
        Tgo,
        Tha,
        Tjk,
        Tkl,
        Tkm,
        Tls,
        Ton,
        Tto,
        Tun,
        Tur,
        Tuv,
        Twn,
        Tza,
        Uga,
        Ukr,
        Umi,
        Ury,
        Usa,
        Uzb,
        Vat,
        Vct,
        Ven,
        Vgb,
        Vir,
        Vnm,
        Vut,
        Wlf,
        Wsm,
        Yem,
        Zaf,
        Zmb,
        Zwe,
    }
    public enum CountryCode
    {
        World,
        Aw,
        Af,
        Ao,
        Ai,
        Ax,
        Al,
        Ad,
        Ae,
        Ar,
        Am,
        As,
        Aq,
        Tf,
        Ag,
        Au,
        At,
        Az,
        Bi,
        Be,
        Bj,
        Bf,
        Bd,
        Bg,
        Bh,
        Bs,
        Ba,
        Bl,
        By,
        Bz,
        Bm,
        Bo,
        Br,
        Bb,
        Bn,
        Bt,
        Bv,
        Bw,
        Cf,
        Ca,
        Cc,
        Ch,
        Cl,
        Cn,
        Ci,
        Cm,
        Cd,
        Cg,
        Ck,
        Co,
        Km,
        Cv,
        Cr,
        Cu,
        Cw,
        Cx,
        Ky,
        Cy,
        Cz,
        De,
        Dj,
        Dm,
        Dk,
        Do,
        Dz,
        Ec,
        Eg,
        Er,
        Eh,
        Es,
        Ee,
        Et,
        Fi,
        Fj,
        Fk,
        Fr,
        Fo,
        Fm,
        Ga,
        Uk,
        Ge,
        Gg,
        Gh,
        Gi,
        Gn,
        Gp,
        Gm,
        Gw,
        Gq,
        Gr,
        Gd,
        Gl,
        Gt,
        Gf,
        Gu,
        Gy,
        Hk,
        Hm,
        Hn,
        Hr,
        Ht,
        Hu,
        Id,
        Im,
        In,
        Io,
        Ie,
        Ir,
        Iq,
        Is,
        Il,
        It,
        Jm,
        Je,
        Jo,
        Jp,
        Kz,
        Ke,
        Kg,
        Kh,
        Ki,
        Kn,
        Kr,
        Xk,
        Kw,
        La,
        Lb,
        Lr,
        Ly,
        Lc,
        Li,
        Lk,
        Ls,
        Lt,
        Lu,
        Lv,
        Mo,
        Mf,
        Ma,
        Mc,
        Md,
        Mg,
        Mv,
        Mx,
        Mh,
        Mk,
        Ml,
        Mt,
        Mm,
        Me,
        Mn,
        Mp,
        Mz,
        Mr,
        Ms,
        Mq,
        Mu,
        Mw,
        My,
        Yt,
        Na,
        Nc,
        Ne,
        Nf,
        Ng,
        Ni,
        Nu,
        Nl,
        No,
        Np,
        Nr,
        Nz,
        Om,
        Pk,
        Pa,
        Pn,
        Pe,
        Ph,
        Pw,
        Pg,
        Pl,
        Pr,
        Kp,
        Pt,
        Py,
        Ps,
        Pf,
        Qa,
        Re,
        Ro,
        Ru,
        Rw,
        Sa,
        Sd,
        Sn,
        Sg,
        Gs,
        Sj,
        Sb,
        Sl,
        Sv,
        Sm,
        So,
        Pm,
        Rs,
        Ss,
        St,
        Sr,
        Sk,
        Si,
        Se,
        Sz,
        Sx,
        Sc,
        Sy,
        Tc,
        Td,
        Tg,
        Th,
        Tj,
        Tk,
        Tm,
        Tl,
        To,
        Tt,
        Tn,
        Tr,
        Tv,
        Tw,
        Tz,
        Ug,
        Ua,
        Um,
        Uy,
        Us,
        Uz,
        Va,
        Vc,
        Ve,
        Vg,
        Vi,
        Vn,
        Vu,
        Wf,
        Ws,
        Ye,
        Za,
        Zm,
        Zw,
    }

    public partial class Country
    {
        public string CommonName { get; private set; }
        public string OfficialName { get; private set; }
        public string[] Tld { get; private set; }
        public CountryCode CountryCode { get; private set; }
        public string IsoNumeric { get; private set; }
        public CountryCodeIso3 Iso3 { get; private set; }
        public string Cioc { get; private set; }
        public string[] Currencies { get; private set; }
        public string[] CallingCodes { get; private set; }
        public string Capital { get; private set; }
        public string[] AlternativeSpellings { get; private set; }
        public string Region { get; private set; }
        public string SubRegion { get; private set; }
        public CountryCodeIso3[] Borders { get; private set; }
        public bool Landlocked { get; private set; }
        public double Area { get; private set; }

        public override bool Equals(object obj)
        {
            var item = obj as Country;

            if (item == null) return false;

            return CountryCode == item.CountryCode;
        }

        public override int GetHashCode()
        {
            return (int)CountryCode;
        }

        public override string ToString()
        {
            return CommonName;
        }

        public static Country Parse(string value)
        {
            CountryCode code;
            if (Enum.TryParse(value, true, out code)) return FromCode(code);

            CountryCodeIso3 isoCode;
            if (Enum.TryParse(value, true, out isoCode)) return FromCode(isoCode);

            return null;
        }

        public static Country FromCode(CountryCode cc)
        {
            return All.FirstOrDefault(x => x.CountryCode == cc) ?? World;
        }

        public static Country FromCode(CountryCodeIso3 cc)
        {
            return All.FirstOrDefault(x => x.Iso3 == cc) ?? World;
        }

        public static IEnumerable<Country> All
        {
            get
            {
                foreach (var k in typeof(Country).GetRuntimeProperties().Where(x => x.PropertyType == typeof(Country)))
                {
                    yield return k.GetValue(null) as Country;
                }
            }
        }

        public static Country World
        {
            get
            {
                return new Country
                {
                    CommonName = "World",
                    OfficialName = "World",
                    Tld = new[] { ".com" },
                    CountryCode = CountryCode.World,
                    IsoNumeric = "",
                    Iso3 = CountryCodeIso3.Abw,
                    Cioc = "",
                    Currencies = new string[0],
                    CallingCodes = new string[0],
                    Capital = "",
                    AlternativeSpellings = new string[0],
                    Region = "",
                    SubRegion = "",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 510072000,
                };
            }
        }

        public static Country Aruba
        {
            get
            {
                return new Country
                {
                    CommonName = "Aruba",
                    OfficialName = "Aruba",
                    Tld = new[] { ".aw" },
                    CountryCode = CountryCode.Aw,
                    IsoNumeric = "533",
                    Iso3 = CountryCodeIso3.Abw,
                    Cioc = "ARU",
                    Currencies = new[] { "AWG" },
                    CallingCodes = new[] { "297" },
                    Capital = "Oranjestad",
                    AlternativeSpellings = new[] { "AW" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 180,
                };
            }
        }
        public static Country Afghanistan
        {
            get
            {
                return new Country
                {
                    CommonName = "Afghanistan",
                    OfficialName = "Islamic Republic of Afghanistan",
                    Tld = new[] { ".af" },
                    CountryCode = CountryCode.Af,
                    IsoNumeric = "004",
                    Iso3 = CountryCodeIso3.Afg,
                    Cioc = "AFG",
                    Currencies = new[] { "AFN" },
                    CallingCodes = new[] { "93" },
                    Capital = "Kabul",
                    AlternativeSpellings = new[] { "AF", "Afġānistān" },
                    Region = "Asia",
                    SubRegion = "Southern Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Irn, CountryCodeIso3.Pak, CountryCodeIso3.Tkm, CountryCodeIso3.Uzb, CountryCodeIso3.Tjk, CountryCodeIso3.Chn },
                    Landlocked = true,
                    Area = 652230,
                };
            }
        }
        public static Country Angola
        {
            get
            {
                return new Country
                {
                    CommonName = "Angola",
                    OfficialName = "Republic of Angola",
                    Tld = new[] { ".ao" },
                    CountryCode = CountryCode.Ao,
                    IsoNumeric = "024",
                    Iso3 = CountryCodeIso3.Ago,
                    Cioc = "ANG",
                    Currencies = new[] { "AOA" },
                    CallingCodes = new[] { "244" },
                    Capital = "Luanda",
                    AlternativeSpellings = new[] { "AO", "República de Angola", "ʁɛpublika de an'ɡɔla" },
                    Region = "Africa",
                    SubRegion = "Middle Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Cog, CountryCodeIso3.Cod, CountryCodeIso3.Zmb, CountryCodeIso3.Nam },
                    Landlocked = false,
                    Area = 1246700,
                };
            }
        }
        public static Country Anguilla
        {
            get
            {
                return new Country
                {
                    CommonName = "Anguilla",
                    OfficialName = "Anguilla",
                    Tld = new[] { ".ai" },
                    CountryCode = CountryCode.Ai,
                    IsoNumeric = "660",
                    Iso3 = CountryCodeIso3.Aia,
                    Cioc = "",
                    Currencies = new[] { "XCD" },
                    CallingCodes = new[] { "1264" },
                    Capital = "The Valley",
                    AlternativeSpellings = new[] { "AI" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 91,
                };
            }
        }
        public static Country ÅlandIslands
        {
            get
            {
                return new Country
                {
                    CommonName = "Åland Islands",
                    OfficialName = "Åland Islands",
                    Tld = new[] { ".ax" },
                    CountryCode = CountryCode.Ax,
                    IsoNumeric = "248",
                    Iso3 = CountryCodeIso3.Ala,
                    Cioc = "",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "358" },
                    Capital = "Mariehamn",
                    AlternativeSpellings = new[] { "AX", "Aaland", "Aland", "Ahvenanmaa" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 1580,
                };
            }
        }
        public static Country Albania
        {
            get
            {
                return new Country
                {
                    CommonName = "Albania",
                    OfficialName = "Republic of Albania",
                    Tld = new[] { ".al" },
                    CountryCode = CountryCode.Al,
                    IsoNumeric = "008",
                    Iso3 = CountryCodeIso3.Alb,
                    Cioc = "ALB",
                    Currencies = new[] { "ALL" },
                    CallingCodes = new[] { "355" },
                    Capital = "Tirana",
                    AlternativeSpellings = new[] { "AL", "Shqipëri", "Shqipëria", "Shqipnia" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Mne, CountryCodeIso3.Grc, CountryCodeIso3.Mkd, CountryCodeIso3.Kos },
                    Landlocked = false,
                    Area = 28748,
                };
            }
        }
        public static Country Andorra
        {
            get
            {
                return new Country
                {
                    CommonName = "Andorra",
                    OfficialName = "Principality of Andorra",
                    Tld = new[] { ".ad" },
                    CountryCode = CountryCode.Ad,
                    IsoNumeric = "020",
                    Iso3 = CountryCodeIso3.And,
                    Cioc = "AND",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "376" },
                    Capital = "Andorra la Vella",
                    AlternativeSpellings = new[] { "AD", "Principality of Andorra", "Principat d'Andorra" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Fra, CountryCodeIso3.Esp },
                    Landlocked = true,
                    Area = 468,
                };
            }
        }
        public static Country UnitedArabEmirates
        {
            get
            {
                return new Country
                {
                    CommonName = "United Arab Emirates",
                    OfficialName = "United Arab Emirates",
                    Tld = new[] { ".ae", "امارات." },
                    CountryCode = CountryCode.Ae,
                    IsoNumeric = "784",
                    Iso3 = CountryCodeIso3.Are,
                    Cioc = "UAE",
                    Currencies = new[] { "AED" },
                    CallingCodes = new[] { "971" },
                    Capital = "Abu Dhabi",
                    AlternativeSpellings = new[] { "AE", "UAE", "Emirates" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Omn, CountryCodeIso3.Sau },
                    Landlocked = false,
                    Area = 83600,
                };
            }
        }
        public static Country Argentina
        {
            get
            {
                return new Country
                {
                    CommonName = "Argentina",
                    OfficialName = "Argentine Republic",
                    Tld = new[] { ".ar" },
                    CountryCode = CountryCode.Ar,
                    IsoNumeric = "032",
                    Iso3 = CountryCodeIso3.Arg,
                    Cioc = "ARG",
                    Currencies = new[] { "ARS" },
                    CallingCodes = new[] { "54" },
                    Capital = "Buenos Aires",
                    AlternativeSpellings = new[] { "AR", "Argentine Republic", "República Argentina" },
                    Region = "Americas",
                    SubRegion = "South America",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Bol, CountryCodeIso3.Bra, CountryCodeIso3.Chl, CountryCodeIso3.Pry, CountryCodeIso3.Ury },
                    Landlocked = false,
                    Area = 2780400,
                };
            }
        }
        public static Country Armenia
        {
            get
            {
                return new Country
                {
                    CommonName = "Armenia",
                    OfficialName = "Republic of Armenia",
                    Tld = new[] { ".am" },
                    CountryCode = CountryCode.Am,
                    IsoNumeric = "051",
                    Iso3 = CountryCodeIso3.Arm,
                    Cioc = "ARM",
                    Currencies = new[] { "AMD" },
                    CallingCodes = new[] { "374" },
                    Capital = "Yerevan",
                    AlternativeSpellings = new[] { "AM", "Hayastan", "Republic of Armenia", "Հայաստանի Հանրապետություն" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Aze, CountryCodeIso3.Geo, CountryCodeIso3.Irn, CountryCodeIso3.Tur },
                    Landlocked = true,
                    Area = 29743,
                };
            }
        }
        public static Country AmericanSamoa
        {
            get
            {
                return new Country
                {
                    CommonName = "American Samoa",
                    OfficialName = "American Samoa",
                    Tld = new[] { ".as" },
                    CountryCode = CountryCode.As,
                    IsoNumeric = "016",
                    Iso3 = CountryCodeIso3.Asm,
                    Cioc = "ASA",
                    Currencies = new[] { "USD" },
                    CallingCodes = new[] { "1684" },
                    Capital = "Pago Pago",
                    AlternativeSpellings = new[] { "AS", "Amerika Sāmoa", "Amelika Sāmoa", "Sāmoa Amelika" },
                    Region = "Oceania",
                    SubRegion = "Polynesia",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 199,
                };
            }
        }
        public static Country Antarctica
        {
            get
            {
                return new Country
                {
                    CommonName = "Antarctica",
                    OfficialName = "Antarctica",
                    Tld = new[] { ".aq" },
                    CountryCode = CountryCode.Aq,
                    IsoNumeric = "010",
                    Iso3 = CountryCodeIso3.Ata,
                    Cioc = "",
                    Currencies = new string[] { },
                    Capital = "",
                    AlternativeSpellings = new[] { "AQ" },
                    Region = "",
                    SubRegion = "",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 14000000,
                };
            }
        }
        public static Country FrenchSouthernandAntarcticLands
        {
            get
            {
                return new Country
                {
                    CommonName = "French Southern and Antarctic Lands",
                    OfficialName = "Territory of the French Southern and Antarctic Lands",
                    Tld = new[] { ".tf" },
                    CountryCode = CountryCode.Tf,
                    IsoNumeric = "260",
                    Iso3 = CountryCodeIso3.Atf,
                    Cioc = "",
                    Currencies = new[] { "EUR" },
                    Capital = "Port-aux-Français",
                    AlternativeSpellings = new[] { "TF", "French Southern Territories" },
                    Region = "",
                    SubRegion = "",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 7747,
                };
            }
        }
        public static Country AntiguaandBarbuda
        {
            get
            {
                return new Country
                {
                    CommonName = "Antigua and Barbuda",
                    OfficialName = "Antigua and Barbuda",
                    Tld = new[] { ".ag" },
                    CountryCode = CountryCode.Ag,
                    IsoNumeric = "028",
                    Iso3 = CountryCodeIso3.Atg,
                    Cioc = "ANT",
                    Currencies = new[] { "XCD" },
                    CallingCodes = new[] { "1268" },
                    Capital = "Saint John's",
                    AlternativeSpellings = new[] { "AG" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 442,
                };
            }
        }
        public static Country Australia
        {
            get
            {
                return new Country
                {
                    CommonName = "Australia",
                    OfficialName = "Commonwealth of Australia",
                    Tld = new[] { ".au" },
                    CountryCode = CountryCode.Au,
                    IsoNumeric = "036",
                    Iso3 = CountryCodeIso3.Aus,
                    Cioc = "AUS",
                    Currencies = new[] { "AUD" },
                    CallingCodes = new[] { "61" },
                    Capital = "Canberra",
                    AlternativeSpellings = new[] { "AU" },
                    Region = "Oceania",
                    SubRegion = "Australia and New Zealand",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 7692024,
                };
            }
        }
        public static Country Austria
        {
            get
            {
                return new Country
                {
                    CommonName = "Austria",
                    OfficialName = "Republic of Austria",
                    Tld = new[] { ".at" },
                    CountryCode = CountryCode.At,
                    IsoNumeric = "040",
                    Iso3 = CountryCodeIso3.Aut,
                    Cioc = "AUT",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "43" },
                    Capital = "Vienna",
                    AlternativeSpellings = new[] { "AT", "Osterreich", "Oesterreich" },
                    Region = "Europe",
                    SubRegion = "Western Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Cze, CountryCodeIso3.Deu, CountryCodeIso3.Hun, CountryCodeIso3.Ita, CountryCodeIso3.Lie, CountryCodeIso3.Svk, CountryCodeIso3.Svn, CountryCodeIso3.Che },
                    Landlocked = true,
                    Area = 83871,
                };
            }
        }
        public static Country Azerbaijan
        {
            get
            {
                return new Country
                {
                    CommonName = "Azerbaijan",
                    OfficialName = "Republic of Azerbaijan",
                    Tld = new[] { ".az" },
                    CountryCode = CountryCode.Az,
                    IsoNumeric = "031",
                    Iso3 = CountryCodeIso3.Aze,
                    Cioc = "AZE",
                    Currencies = new[] { "AZN" },
                    CallingCodes = new[] { "994" },
                    Capital = "Baku",
                    AlternativeSpellings = new[] { "AZ", "Republic of Azerbaijan", "Azərbaycan Respublikası" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Arm, CountryCodeIso3.Geo, CountryCodeIso3.Irn, CountryCodeIso3.Rus, CountryCodeIso3.Tur },
                    Landlocked = true,
                    Area = 86600,
                };
            }
        }
        public static Country Burundi
        {
            get
            {
                return new Country
                {
                    CommonName = "Burundi",
                    OfficialName = "Republic of Burundi",
                    Tld = new[] { ".bi" },
                    CountryCode = CountryCode.Bi,
                    IsoNumeric = "108",
                    Iso3 = CountryCodeIso3.Bdi,
                    Cioc = "BDI",
                    Currencies = new[] { "BIF" },
                    CallingCodes = new[] { "257" },
                    Capital = "Bujumbura",
                    AlternativeSpellings = new[] { "BI", "Republic of Burundi", "Republika y'Uburundi", "République du Burundi" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Cod, CountryCodeIso3.Rwa, CountryCodeIso3.Tza },
                    Landlocked = true,
                    Area = 27834,
                };
            }
        }
        public static Country Belgium
        {
            get
            {
                return new Country
                {
                    CommonName = "Belgium",
                    OfficialName = "Kingdom of Belgium",
                    Tld = new[] { ".be" },
                    CountryCode = CountryCode.Be,
                    IsoNumeric = "056",
                    Iso3 = CountryCodeIso3.Bel,
                    Cioc = "BEL",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "32" },
                    Capital = "Brussels",
                    AlternativeSpellings = new[] { "BE", "België", "Belgie", "Belgien", "Belgique", "Kingdom of Belgium", "Koninkrijk België", "Royaume de Belgique", "Königreich Belgien" },
                    Region = "Europe",
                    SubRegion = "Western Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Fra, CountryCodeIso3.Deu, CountryCodeIso3.Lux, CountryCodeIso3.Nld },
                    Landlocked = false,
                    Area = 30528,
                };
            }
        }
        public static Country Benin
        {
            get
            {
                return new Country
                {
                    CommonName = "Benin",
                    OfficialName = "Republic of Benin",
                    Tld = new[] { ".bj" },
                    CountryCode = CountryCode.Bj,
                    IsoNumeric = "204",
                    Iso3 = CountryCodeIso3.Ben,
                    Cioc = "BEN",
                    Currencies = new[] { "XOF" },
                    CallingCodes = new[] { "229" },
                    Capital = "Porto-Novo",
                    AlternativeSpellings = new[] { "BJ", "Republic of Benin", "République du Bénin" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Bfa, CountryCodeIso3.Ner, CountryCodeIso3.Nga, CountryCodeIso3.Tgo },
                    Landlocked = false,
                    Area = 112622,
                };
            }
        }
        public static Country BurkinaFaso
        {
            get
            {
                return new Country
                {
                    CommonName = "Burkina Faso",
                    OfficialName = "Burkina Faso",
                    Tld = new[] { ".bf" },
                    CountryCode = CountryCode.Bf,
                    IsoNumeric = "854",
                    Iso3 = CountryCodeIso3.Bfa,
                    Cioc = "BUR",
                    Currencies = new[] { "XOF" },
                    CallingCodes = new[] { "226" },
                    Capital = "Ouagadougou",
                    AlternativeSpellings = new[] { "BF" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Ben, CountryCodeIso3.Civ, CountryCodeIso3.Gha, CountryCodeIso3.Mli, CountryCodeIso3.Ner, CountryCodeIso3.Tgo },
                    Landlocked = true,
                    Area = 272967,
                };
            }
        }
        public static Country Bangladesh
        {
            get
            {
                return new Country
                {
                    CommonName = "Bangladesh",
                    OfficialName = "People's Republic of Bangladesh",
                    Tld = new[] { ".bd" },
                    CountryCode = CountryCode.Bd,
                    IsoNumeric = "050",
                    Iso3 = CountryCodeIso3.Bgd,
                    Cioc = "BAN",
                    Currencies = new[] { "BDT" },
                    CallingCodes = new[] { "880" },
                    Capital = "Dhaka",
                    AlternativeSpellings = new[] { "BD", "People's Republic of Bangladesh", "Gônôprôjatôntri Bangladesh" },
                    Region = "Asia",
                    SubRegion = "Southern Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Mmr, CountryCodeIso3.Ind },
                    Landlocked = false,
                    Area = 147570,
                };
            }
        }
        public static Country Bulgaria
        {
            get
            {
                return new Country
                {
                    CommonName = "Bulgaria",
                    OfficialName = "Republic of Bulgaria",
                    Tld = new[] { ".bg" },
                    CountryCode = CountryCode.Bg,
                    IsoNumeric = "100",
                    Iso3 = CountryCodeIso3.Bgr,
                    Cioc = "BUL",
                    Currencies = new[] { "BGN" },
                    CallingCodes = new[] { "359" },
                    Capital = "Sofia",
                    AlternativeSpellings = new[] { "BG", "Republic of Bulgaria", "Република България" },
                    Region = "Europe",
                    SubRegion = "Eastern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Grc, CountryCodeIso3.Mkd, CountryCodeIso3.Rou, CountryCodeIso3.Srb, CountryCodeIso3.Tur },
                    Landlocked = false,
                    Area = 110879,
                };
            }
        }
        public static Country Bahrain
        {
            get
            {
                return new Country
                {
                    CommonName = "Bahrain",
                    OfficialName = "Kingdom of Bahrain",
                    Tld = new[] { ".bh" },
                    CountryCode = CountryCode.Bh,
                    IsoNumeric = "048",
                    Iso3 = CountryCodeIso3.Bhr,
                    Cioc = "BRN",
                    Currencies = new[] { "BHD" },
                    CallingCodes = new[] { "973" },
                    Capital = "Manama",
                    AlternativeSpellings = new[] { "BH", "Kingdom of Bahrain", "Mamlakat al-Baḥrayn" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 765,
                };
            }
        }
        public static Country Bahamas
        {
            get
            {
                return new Country
                {
                    CommonName = "Bahamas",
                    OfficialName = "Commonwealth of the Bahamas",
                    Tld = new[] { ".bs" },
                    CountryCode = CountryCode.Bs,
                    IsoNumeric = "044",
                    Iso3 = CountryCodeIso3.Bhs,
                    Cioc = "BAH",
                    Currencies = new[] { "BSD" },
                    CallingCodes = new[] { "1242" },
                    Capital = "Nassau",
                    AlternativeSpellings = new[] { "BS", "Commonwealth of the Bahamas" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 13943,
                };
            }
        }
        public static Country BosniaandHerzegovina
        {
            get
            {
                return new Country
                {
                    CommonName = "Bosnia and Herzegovina",
                    OfficialName = "Bosnia and Herzegovina",
                    Tld = new[] { ".ba" },
                    CountryCode = CountryCode.Ba,
                    IsoNumeric = "070",
                    Iso3 = CountryCodeIso3.Bih,
                    Cioc = "BIH",
                    Currencies = new[] { "BAM" },
                    CallingCodes = new[] { "387" },
                    Capital = "Sarajevo",
                    AlternativeSpellings = new[] { "BA", "Bosnia-Herzegovina", "Босна и Херцеговина" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Hrv, CountryCodeIso3.Mne, CountryCodeIso3.Srb },
                    Landlocked = false,
                    Area = 51209,
                };
            }
        }
        public static Country SaintBarthélemy
        {
            get
            {
                return new Country
                {
                    CommonName = "Saint Barthélemy",
                    OfficialName = "Collectivity of Saint BarthélemySaint Barthélemy",
                    Tld = new[] { ".bl" },
                    CountryCode = CountryCode.Bl,
                    IsoNumeric = "652",
                    Iso3 = CountryCodeIso3.Blm,
                    Cioc = "",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "590" },
                    Capital = "Gustavia",
                    AlternativeSpellings = new[] { "BL", "St. Barthelemy", "Collectivity of Saint Barthélemy", "Collectivité de Saint-Barthélemy" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 21,
                };
            }
        }
        public static Country Belarus
        {
            get
            {
                return new Country
                {
                    CommonName = "Belarus",
                    OfficialName = "Republic of Belarus",
                    Tld = new[] { ".by" },
                    CountryCode = CountryCode.By,
                    IsoNumeric = "112",
                    Iso3 = CountryCodeIso3.Blr,
                    Cioc = "BLR",
                    Currencies = new[] { "BYR" },
                    CallingCodes = new[] { "375" },
                    Capital = "Minsk",
                    AlternativeSpellings = new[] { "BY", "Bielaruś", "Republic of Belarus", "Белоруссия", "Республика Беларусь", "Belorussiya", "Respublika Belarus’" },
                    Region = "Europe",
                    SubRegion = "Eastern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Lva, CountryCodeIso3.Ltu, CountryCodeIso3.Pol, CountryCodeIso3.Rus, CountryCodeIso3.Ukr },
                    Landlocked = true,
                    Area = 207600,
                };
            }
        }
        public static Country Belize
        {
            get
            {
                return new Country
                {
                    CommonName = "Belize",
                    OfficialName = "Belize",
                    Tld = new[] { ".bz" },
                    CountryCode = CountryCode.Bz,
                    IsoNumeric = "084",
                    Iso3 = CountryCodeIso3.Blz,
                    Cioc = "BIZ",
                    Currencies = new[] { "BZD" },
                    CallingCodes = new[] { "501" },
                    Capital = "Belmopan",
                    AlternativeSpellings = new[] { "BZ" },
                    Region = "Americas",
                    SubRegion = "Central America",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Gtm, CountryCodeIso3.Mex },
                    Landlocked = false,
                    Area = 22966,
                };
            }
        }
        public static Country Bermuda
        {
            get
            {
                return new Country
                {
                    CommonName = "Bermuda",
                    OfficialName = "Bermuda",
                    Tld = new[] { ".bm" },
                    CountryCode = CountryCode.Bm,
                    IsoNumeric = "060",
                    Iso3 = CountryCodeIso3.Bmu,
                    Cioc = "BER",
                    Currencies = new[] { "BMD" },
                    CallingCodes = new[] { "1441" },
                    Capital = "Hamilton",
                    AlternativeSpellings = new[] { "BM", "The Islands of Bermuda", "The Bermudas", "Somers Isles" },
                    Region = "Americas",
                    SubRegion = "Northern America",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 54,
                };
            }
        }
        public static Country Bolivia
        {
            get
            {
                return new Country
                {
                    CommonName = "Bolivia",
                    OfficialName = "Plurinational State of Bolivia",
                    Tld = new[] { ".bo" },
                    CountryCode = CountryCode.Bo,
                    IsoNumeric = "068",
                    Iso3 = CountryCodeIso3.Bol,
                    Cioc = "BOL",
                    Currencies = new[] { "BOB", "BOV" },
                    CallingCodes = new[] { "591" },
                    Capital = "Sucre",
                    AlternativeSpellings = new[] { "BO", "Buliwya", "Wuliwya", "Bolivia, Plurinational State of", "Plurinational State of Bolivia", "Estado Plurinacional de Bolivia", "Buliwya Mamallaqta", "Wuliwya Suyu", "Tetã Volívia" },
                    Region = "Americas",
                    SubRegion = "South America",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Arg, CountryCodeIso3.Bra, CountryCodeIso3.Chl, CountryCodeIso3.Pry, CountryCodeIso3.Per },
                    Landlocked = true,
                    Area = 1098581,
                };
            }
        }
        public static Country Brazil
        {
            get
            {
                return new Country
                {
                    CommonName = "Brazil",
                    OfficialName = "Federative Republic of Brazil",
                    Tld = new[] { ".br" },
                    CountryCode = CountryCode.Br,
                    IsoNumeric = "076",
                    Iso3 = CountryCodeIso3.Bra,
                    Cioc = "BRA",
                    Currencies = new[] { "BRL" },
                    CallingCodes = new[] { "55" },
                    Capital = "Brasília",
                    AlternativeSpellings = new[] { "BR", "Brasil", "Federative Republic of Brazil", "República Federativa do Brasil" },
                    Region = "Americas",
                    SubRegion = "South America",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Arg, CountryCodeIso3.Bol, CountryCodeIso3.Col, CountryCodeIso3.Guf, CountryCodeIso3.Guy, CountryCodeIso3.Pry, CountryCodeIso3.Per, CountryCodeIso3.Sur, CountryCodeIso3.Ury, CountryCodeIso3.Ven },
                    Landlocked = false,
                    Area = 8515767,
                };
            }
        }
        public static Country Barbados
        {
            get
            {
                return new Country
                {
                    CommonName = "Barbados",
                    OfficialName = "Barbados",
                    Tld = new[] { ".bb" },
                    CountryCode = CountryCode.Bb,
                    IsoNumeric = "052",
                    Iso3 = CountryCodeIso3.Brb,
                    Cioc = "BAR",
                    Currencies = new[] { "BBD" },
                    CallingCodes = new[] { "1246" },
                    Capital = "Bridgetown",
                    AlternativeSpellings = new[] { "BB" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 430,
                };
            }
        }
        public static Country Brunei
        {
            get
            {
                return new Country
                {
                    CommonName = "Brunei",
                    OfficialName = "Nation of Brunei, Abode of Peace",
                    Tld = new[] { ".bn" },
                    CountryCode = CountryCode.Bn,
                    IsoNumeric = "096",
                    Iso3 = CountryCodeIso3.Brn,
                    Cioc = "BRU",
                    Currencies = new[] { "BND" },
                    CallingCodes = new[] { "673" },
                    Capital = "Bandar Seri Begawan",
                    AlternativeSpellings = new[] { "BN", "Brunei Darussalam", "Nation of Brunei", "the Abode of Peace" },
                    Region = "Asia",
                    SubRegion = "South-Eastern Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Mys },
                    Landlocked = false,
                    Area = 5765,
                };
            }
        }
        public static Country Bhutan
        {
            get
            {
                return new Country
                {
                    CommonName = "Bhutan",
                    OfficialName = "Kingdom of Bhutan",
                    Tld = new[] { ".bt" },
                    CountryCode = CountryCode.Bt,
                    IsoNumeric = "064",
                    Iso3 = CountryCodeIso3.Btn,
                    Cioc = "BHU",
                    Currencies = new[] { "BTN", "INR" },
                    CallingCodes = new[] { "975" },
                    Capital = "Thimphu",
                    AlternativeSpellings = new[] { "BT", "Kingdom of Bhutan" },
                    Region = "Asia",
                    SubRegion = "Southern Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Chn, CountryCodeIso3.Ind },
                    Landlocked = true,
                    Area = 38394,
                };
            }
        }
        public static Country BouvetIsland
        {
            get
            {
                return new Country
                {
                    CommonName = "Bouvet Island",
                    OfficialName = "Bouvet Island",
                    Tld = new[] { ".bv" },
                    CountryCode = CountryCode.Bv,
                    IsoNumeric = "074",
                    Iso3 = CountryCodeIso3.Bvt,
                    Cioc = "",
                    Currencies = new[] { "NOK" },
                    Capital = "",
                    AlternativeSpellings = new[] { "BV", "Bouvetøya", "Bouvet-øya" },
                    Region = "",
                    SubRegion = "",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 49,
                };
            }
        }
        public static Country Botswana
        {
            get
            {
                return new Country
                {
                    CommonName = "Botswana",
                    OfficialName = "Republic of Botswana",
                    Tld = new[] { ".bw" },
                    CountryCode = CountryCode.Bw,
                    IsoNumeric = "072",
                    Iso3 = CountryCodeIso3.Bwa,
                    Cioc = "BOT",
                    Currencies = new[] { "BWP" },
                    CallingCodes = new[] { "267" },
                    Capital = "Gaborone",
                    AlternativeSpellings = new[] { "BW", "Republic of Botswana", "Lefatshe la Botswana" },
                    Region = "Africa",
                    SubRegion = "Southern Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Nam, CountryCodeIso3.Zaf, CountryCodeIso3.Zmb, CountryCodeIso3.Zwe },
                    Landlocked = true,
                    Area = 582000,
                };
            }
        }
        public static Country CentralAfricanRepublic
        {
            get
            {
                return new Country
                {
                    CommonName = "Central African Republic",
                    OfficialName = "Central African Republic",
                    Tld = new[] { ".cf" },
                    CountryCode = CountryCode.Cf,
                    IsoNumeric = "140",
                    Iso3 = CountryCodeIso3.Caf,
                    Cioc = "CAF",
                    Currencies = new[] { "XAF" },
                    CallingCodes = new[] { "236" },
                    Capital = "Bangui",
                    AlternativeSpellings = new[] { "CF", "Central African Republic", "République centrafricaine" },
                    Region = "Africa",
                    SubRegion = "Middle Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Cmr, CountryCodeIso3.Tcd, CountryCodeIso3.Cod, CountryCodeIso3.Cog, CountryCodeIso3.Ssd, CountryCodeIso3.Sdn },
                    Landlocked = true,
                    Area = 622984,
                };
            }
        }
        public static Country Canada
        {
            get
            {
                return new Country
                {
                    CommonName = "Canada",
                    OfficialName = "Canada",
                    Tld = new[] { ".ca" },
                    CountryCode = CountryCode.Ca,
                    IsoNumeric = "124",
                    Iso3 = CountryCodeIso3.Can,
                    Cioc = "CAN",
                    Currencies = new[] { "CAD" },
                    CallingCodes = new[] { "1" },
                    Capital = "Ottawa",
                    AlternativeSpellings = new[] { "CA" },
                    Region = "Americas",
                    SubRegion = "Northern America",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Usa },
                    Landlocked = false,
                    Area = 9984670,
                };
            }
        }
        public static Country CocosKeelingIslands
        {
            get
            {
                return new Country
                {
                    CommonName = "Cocos (Keeling) Islands",
                    OfficialName = "Territory of the Cocos (Keeling) Islands",
                    Tld = new[] { ".cc" },
                    CountryCode = CountryCode.Cc,
                    IsoNumeric = "166",
                    Iso3 = CountryCodeIso3.Cck,
                    Cioc = "",
                    Currencies = new[] { "AUD" },
                    CallingCodes = new[] { "61" },
                    Capital = "West Island",
                    AlternativeSpellings = new[] { "CC", "Territory of the Cocos (Keeling) Islands", "Keeling Islands" },
                    Region = "Oceania",
                    SubRegion = "Australia and New Zealand",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 14,
                };
            }
        }
        public static Country Switzerland
        {
            get
            {
                return new Country
                {
                    CommonName = "Switzerland",
                    OfficialName = "Swiss Confederation",
                    Tld = new[] { ".ch" },
                    CountryCode = CountryCode.Ch,
                    IsoNumeric = "756",
                    Iso3 = CountryCodeIso3.Che,
                    Cioc = "SUI",
                    Currencies = new[] { "CHE", "CHF", "CHW" },
                    CallingCodes = new[] { "41" },
                    Capital = "Bern",
                    AlternativeSpellings = new[] { "CH", "Swiss Confederation", "Schweiz", "Suisse", "Svizzera", "Svizra" },
                    Region = "Europe",
                    SubRegion = "Western Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Aut, CountryCodeIso3.Fra, CountryCodeIso3.Ita, CountryCodeIso3.Lie, CountryCodeIso3.Deu },
                    Landlocked = true,
                    Area = 41284,
                };
            }
        }
        public static Country Chile
        {
            get
            {
                return new Country
                {
                    CommonName = "Chile",
                    OfficialName = "Republic of Chile",
                    Tld = new[] { ".cl" },
                    CountryCode = CountryCode.Cl,
                    IsoNumeric = "152",
                    Iso3 = CountryCodeIso3.Chl,
                    Cioc = "CHI",
                    Currencies = new[] { "CLF", "CLP" },
                    CallingCodes = new[] { "56" },
                    Capital = "Santiago",
                    AlternativeSpellings = new[] { "CL", "Republic of Chile", "República de Chile" },
                    Region = "Americas",
                    SubRegion = "South America",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Arg, CountryCodeIso3.Bol, CountryCodeIso3.Per },
                    Landlocked = false,
                    Area = 756102,
                };
            }
        }
        public static Country China
        {
            get
            {
                return new Country
                {
                    CommonName = "China",
                    OfficialName = "People's Republic of China",
                    Tld = new[] { ".cn", ".中国", ".中國", ".公司", ".网络" },
                    CountryCode = CountryCode.Cn,
                    IsoNumeric = "156",
                    Iso3 = CountryCodeIso3.Chn,
                    Cioc = "CHN",
                    Currencies = new[] { "CNY" },
                    CallingCodes = new[] { "86" },
                    Capital = "Beijing",
                    AlternativeSpellings = new[] { "CN", "Zhōngguó", "Zhongguo", "Zhonghua", "People's Republic of China", "中华人民共和国", "Zhōnghuá Rénmín Gònghéguó" },
                    Region = "Asia",
                    SubRegion = "Eastern Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Afg, CountryCodeIso3.Btn, CountryCodeIso3.Mmr, CountryCodeIso3.Hkg, CountryCodeIso3.Ind, CountryCodeIso3.Kaz, CountryCodeIso3.Prk, CountryCodeIso3.Kgz, CountryCodeIso3.Lao, CountryCodeIso3.Mac, CountryCodeIso3.Mng, CountryCodeIso3.Pak, CountryCodeIso3.Rus, CountryCodeIso3.Tjk, CountryCodeIso3.Vnm },
                    Landlocked = false,
                    Area = 9706961,
                };
            }
        }
        public static Country IvoryCoast
        {
            get
            {
                return new Country
                {
                    CommonName = "Ivory Coast",
                    OfficialName = "Republic of Côte d'Ivoire",
                    Tld = new[] { ".ci" },
                    CountryCode = CountryCode.Ci,
                    IsoNumeric = "384",
                    Iso3 = CountryCodeIso3.Civ,
                    Cioc = "CIV",
                    Currencies = new[] { "XOF" },
                    CallingCodes = new[] { "225" },
                    Capital = "Yamoussoukro",
                    AlternativeSpellings = new[] { "CI", "Côte d'Ivoire", "Ivory Coast", "Republic of Côte d'Ivoire", "République de Côte d'Ivoire" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Bfa, CountryCodeIso3.Gha, CountryCodeIso3.Gin, CountryCodeIso3.Lbr, CountryCodeIso3.Mli },
                    Landlocked = false,
                    Area = 322463,
                };
            }
        }
        public static Country Cameroon
        {
            get
            {
                return new Country
                {
                    CommonName = "Cameroon",
                    OfficialName = "Republic of Cameroon",
                    Tld = new[] { ".cm" },
                    CountryCode = CountryCode.Cm,
                    IsoNumeric = "120",
                    Iso3 = CountryCodeIso3.Cmr,
                    Cioc = "CMR",
                    Currencies = new[] { "XAF" },
                    CallingCodes = new[] { "237" },
                    Capital = "Yaoundé",
                    AlternativeSpellings = new[] { "CM", "Republic of Cameroon", "République du Cameroun" },
                    Region = "Africa",
                    SubRegion = "Middle Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Caf, CountryCodeIso3.Tcd, CountryCodeIso3.Cog, CountryCodeIso3.Gnq, CountryCodeIso3.Gab, CountryCodeIso3.Nga },
                    Landlocked = false,
                    Area = 475442,
                };
            }
        }
        public static Country DrCongo
        {
            get
            {
                return new Country
                {
                    CommonName = "DR Congo",
                    OfficialName = "Democratic Republic of the Congo",
                    Tld = new[] { ".cd" },
                    CountryCode = CountryCode.Cd,
                    IsoNumeric = "180",
                    Iso3 = CountryCodeIso3.Cod,
                    Cioc = "COD",
                    Currencies = new[] { "CDF" },
                    CallingCodes = new[] { "243" },
                    Capital = "Kinshasa",
                    AlternativeSpellings = new[] { "CD", "DR Congo", "Congo-Kinshasa", "Congo, the Democratic Republic of the", "DRC" },
                    Region = "Africa",
                    SubRegion = "Middle Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Ago, CountryCodeIso3.Bdi, CountryCodeIso3.Caf, CountryCodeIso3.Cog, CountryCodeIso3.Rwa, CountryCodeIso3.Ssd, CountryCodeIso3.Tza, CountryCodeIso3.Uga, CountryCodeIso3.Zmb },
                    Landlocked = false,
                    Area = 2344858,
                };
            }
        }
        public static Country RepublicoftheCongo
        {
            get
            {
                return new Country
                {
                    CommonName = "Republic of the Congo",
                    OfficialName = "Republic of the Congo",
                    Tld = new[] { ".cg" },
                    CountryCode = CountryCode.Cg,
                    IsoNumeric = "178",
                    Iso3 = CountryCodeIso3.Cog,
                    Cioc = "CGO",
                    Currencies = new[] { "XAF" },
                    CallingCodes = new[] { "242" },
                    Capital = "Brazzaville",
                    AlternativeSpellings = new[] { "CG", "Congo", "Congo-Brazzaville" },
                    Region = "Africa",
                    SubRegion = "Middle Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Ago, CountryCodeIso3.Cmr, CountryCodeIso3.Caf, CountryCodeIso3.Cod, CountryCodeIso3.Gab },
                    Landlocked = false,
                    Area = 342000,
                };
            }
        }
        public static Country CookIslands
        {
            get
            {
                return new Country
                {
                    CommonName = "Cook Islands",
                    OfficialName = "Cook Islands",
                    Tld = new[] { ".ck" },
                    CountryCode = CountryCode.Ck,
                    IsoNumeric = "184",
                    Iso3 = CountryCodeIso3.Cok,
                    Cioc = "COK",
                    Currencies = new[] { "NZD" },
                    CallingCodes = new[] { "682" },
                    Capital = "Avarua",
                    AlternativeSpellings = new[] { "CK", "Kūki 'Āirani" },
                    Region = "Oceania",
                    SubRegion = "Polynesia",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 236,
                };
            }
        }
        public static Country Colombia
        {
            get
            {
                return new Country
                {
                    CommonName = "Colombia",
                    OfficialName = "Republic of Colombia",
                    Tld = new[] { ".co" },
                    CountryCode = CountryCode.Co,
                    IsoNumeric = "170",
                    Iso3 = CountryCodeIso3.Col,
                    Cioc = "COL",
                    Currencies = new[] { "COP" },
                    CallingCodes = new[] { "57" },
                    Capital = "Bogotá",
                    AlternativeSpellings = new[] { "CO", "Republic of Colombia", "República de Colombia" },
                    Region = "Americas",
                    SubRegion = "South America",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Bra, CountryCodeIso3.Ecu, CountryCodeIso3.Pan, CountryCodeIso3.Per, CountryCodeIso3.Ven },
                    Landlocked = false,
                    Area = 1141748,
                };
            }
        }
        public static Country Comoros
        {
            get
            {
                return new Country
                {
                    CommonName = "Comoros",
                    OfficialName = "Union of the Comoros",
                    Tld = new[] { ".km" },
                    CountryCode = CountryCode.Km,
                    IsoNumeric = "174",
                    Iso3 = CountryCodeIso3.Com,
                    Cioc = "COM",
                    Currencies = new[] { "KMF" },
                    CallingCodes = new[] { "269" },
                    Capital = "Moroni",
                    AlternativeSpellings = new[] { "KM", "Union of the Comoros", "Union des Comores", "Udzima wa Komori", "al-Ittiḥād al-Qumurī" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 1862,
                };
            }
        }
        public static Country CapeVerde
        {
            get
            {
                return new Country
                {
                    CommonName = "Cape Verde",
                    OfficialName = "Republic of Cabo Verde",
                    Tld = new[] { ".cv" },
                    CountryCode = CountryCode.Cv,
                    IsoNumeric = "132",
                    Iso3 = CountryCodeIso3.Cpv,
                    Cioc = "CPV",
                    Currencies = new[] { "CVE" },
                    CallingCodes = new[] { "238" },
                    Capital = "Praia",
                    AlternativeSpellings = new[] { "CV", "Republic of Cabo Verde", "República de Cabo Verde" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 4033,
                };
            }
        }
        public static Country CostaRica
        {
            get
            {
                return new Country
                {
                    CommonName = "Costa Rica",
                    OfficialName = "Republic of Costa Rica",
                    Tld = new[] { ".cr" },
                    CountryCode = CountryCode.Cr,
                    IsoNumeric = "188",
                    Iso3 = CountryCodeIso3.Cri,
                    Cioc = "CRC",
                    Currencies = new[] { "CRC" },
                    CallingCodes = new[] { "506" },
                    Capital = "San José",
                    AlternativeSpellings = new[] { "CR", "Republic of Costa Rica", "República de Costa Rica" },
                    Region = "Americas",
                    SubRegion = "Central America",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Nic, CountryCodeIso3.Pan },
                    Landlocked = false,
                    Area = 51100,
                };
            }
        }
        public static Country Cuba
        {
            get
            {
                return new Country
                {
                    CommonName = "Cuba",
                    OfficialName = "Republic of Cuba",
                    Tld = new[] { ".cu" },
                    CountryCode = CountryCode.Cu,
                    IsoNumeric = "192",
                    Iso3 = CountryCodeIso3.Cub,
                    Cioc = "CUB",
                    Currencies = new[] { "CUC", "CUP" },
                    CallingCodes = new[] { "53" },
                    Capital = "Havana",
                    AlternativeSpellings = new[] { "CU", "Republic of Cuba", "República de Cuba" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 109884,
                };
            }
        }
        public static Country Curaçao
        {
            get
            {
                return new Country
                {
                    CommonName = "Curaçao",
                    OfficialName = "Country of Curaçao",
                    Tld = new[] { ".cw" },
                    CountryCode = CountryCode.Cw,
                    IsoNumeric = "531",
                    Iso3 = CountryCodeIso3.Cuw,
                    Cioc = "",
                    Currencies = new[] { "ANG" },
                    CallingCodes = new[] { "5999" },
                    Capital = "Willemstad",
                    AlternativeSpellings = new[] { "CW", "Curacao", "Kòrsou", "Country of Curaçao", "Land Curaçao", "Pais Kòrsou" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 444,
                };
            }
        }
        public static Country ChristmasIsland
        {
            get
            {
                return new Country
                {
                    CommonName = "Christmas Island",
                    OfficialName = "Territory of Christmas Island",
                    Tld = new[] { ".cx" },
                    CountryCode = CountryCode.Cx,
                    IsoNumeric = "162",
                    Iso3 = CountryCodeIso3.Cxr,
                    Cioc = "",
                    Currencies = new[] { "AUD" },
                    CallingCodes = new[] { "61" },
                    Capital = "Flying Fish Cove",
                    AlternativeSpellings = new[] { "CX", "Territory of Christmas Island" },
                    Region = "Oceania",
                    SubRegion = "Australia and New Zealand",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 135,
                };
            }
        }
        public static Country CaymanIslands
        {
            get
            {
                return new Country
                {
                    CommonName = "Cayman Islands",
                    OfficialName = "Cayman Islands",
                    Tld = new[] { ".ky" },
                    CountryCode = CountryCode.Ky,
                    IsoNumeric = "136",
                    Iso3 = CountryCodeIso3.Cym,
                    Cioc = "CAY",
                    Currencies = new[] { "KYD" },
                    CallingCodes = new[] { "1345" },
                    Capital = "George Town",
                    AlternativeSpellings = new[] { "KY" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 264,
                };
            }
        }
        public static Country Cyprus
        {
            get
            {
                return new Country
                {
                    CommonName = "Cyprus",
                    OfficialName = "Republic of Cyprus",
                    Tld = new[] { ".cy" },
                    CountryCode = CountryCode.Cy,
                    IsoNumeric = "196",
                    Iso3 = CountryCodeIso3.Cyp,
                    Cioc = "CYP",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "357" },
                    Capital = "Nicosia",
                    AlternativeSpellings = new[] { "CY", "Kýpros", "Kıbrıs", "Republic of Cyprus", "Κυπριακή Δημοκρατία", "Kıbrıs Cumhuriyeti" },
                    Region = "Europe",
                    SubRegion = "Eastern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Gbr },
                    Landlocked = false,
                    Area = 9251,
                };
            }
        }
        public static Country CzechRepublic
        {
            get
            {
                return new Country
                {
                    CommonName = "Czech Republic",
                    OfficialName = "Czech Republic",
                    Tld = new[] { ".cz" },
                    CountryCode = CountryCode.Cz,
                    IsoNumeric = "203",
                    Iso3 = CountryCodeIso3.Cze,
                    Cioc = "CZE",
                    Currencies = new[] { "CZK" },
                    CallingCodes = new[] { "420" },
                    Capital = "Prague",
                    AlternativeSpellings = new[] { "CZ", "Česká republika", "Česko" },
                    Region = "Europe",
                    SubRegion = "Eastern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Aut, CountryCodeIso3.Deu, CountryCodeIso3.Pol, CountryCodeIso3.Svk },
                    Landlocked = true,
                    Area = 78865,
                };
            }
        }
        public static Country Germany
        {
            get
            {
                return new Country
                {
                    CommonName = "Germany",
                    OfficialName = "Federal Republic of Germany",
                    Tld = new[] { ".de" },
                    CountryCode = CountryCode.De,
                    IsoNumeric = "276",
                    Iso3 = CountryCodeIso3.Deu,
                    Cioc = "GER",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "49" },
                    Capital = "Berlin",
                    AlternativeSpellings = new[] { "DE", "Federal Republic of Germany", "Bundesrepublik Deutschland" },
                    Region = "Europe",
                    SubRegion = "Western Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Aut, CountryCodeIso3.Bel, CountryCodeIso3.Cze, CountryCodeIso3.Dnk, CountryCodeIso3.Fra, CountryCodeIso3.Lux, CountryCodeIso3.Nld, CountryCodeIso3.Pol, CountryCodeIso3.Che },
                    Landlocked = false,
                    Area = 357114,
                };
            }
        }
        public static Country Djibouti
        {
            get
            {
                return new Country
                {
                    CommonName = "Djibouti",
                    OfficialName = "Republic of Djibouti",
                    Tld = new[] { ".dj" },
                    CountryCode = CountryCode.Dj,
                    IsoNumeric = "262",
                    Iso3 = CountryCodeIso3.Dji,
                    Cioc = "DJI",
                    Currencies = new[] { "DJF" },
                    CallingCodes = new[] { "253" },
                    Capital = "Djibouti",
                    AlternativeSpellings = new[] { "DJ", "Jabuuti", "Gabuuti", "Republic of Djibouti", "République de Djibouti", "Gabuutih Ummuuno", "Jamhuuriyadda Jabuuti" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Eri, CountryCodeIso3.Eth, CountryCodeIso3.Som },
                    Landlocked = false,
                    Area = 23200,
                };
            }
        }
        public static Country Dominica
        {
            get
            {
                return new Country
                {
                    CommonName = "Dominica",
                    OfficialName = "Commonwealth of Dominica",
                    Tld = new[] { ".dm" },
                    CountryCode = CountryCode.Dm,
                    IsoNumeric = "212",
                    Iso3 = CountryCodeIso3.Dma,
                    Cioc = "DMA",
                    Currencies = new[] { "XCD" },
                    CallingCodes = new[] { "1767" },
                    Capital = "Roseau",
                    AlternativeSpellings = new[] { "DM", "Dominique", "Wai‘tu kubuli", "Commonwealth of Dominica" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 751,
                };
            }
        }
        public static Country Denmark
        {
            get
            {
                return new Country
                {
                    CommonName = "Denmark",
                    OfficialName = "Kingdom of Denmark",
                    Tld = new[] { ".dk" },
                    CountryCode = CountryCode.Dk,
                    IsoNumeric = "208",
                    Iso3 = CountryCodeIso3.Dnk,
                    Cioc = "DEN",
                    Currencies = new[] { "DKK" },
                    CallingCodes = new[] { "45" },
                    Capital = "Copenhagen",
                    AlternativeSpellings = new[] { "DK", "Danmark", "Kingdom of Denmark", "Kongeriget Danmark" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Deu },
                    Landlocked = false,
                    Area = 43094,
                };
            }
        }
        public static Country DominicanRepublic
        {
            get
            {
                return new Country
                {
                    CommonName = "Dominican Republic",
                    OfficialName = "Dominican Republic",
                    Tld = new[] { ".do" },
                    CountryCode = CountryCode.Do,
                    IsoNumeric = "214",
                    Iso3 = CountryCodeIso3.Dom,
                    Cioc = "DOM",
                    Currencies = new[] { "DOP" },
                    CallingCodes = new[] { "1809", "1829", "1849" },
                    Capital = "Santo Domingo",
                    AlternativeSpellings = new[] { "DO" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Hti },
                    Landlocked = false,
                    Area = 48671,
                };
            }
        }
        public static Country Algeria
        {
            get
            {
                return new Country
                {
                    CommonName = "Algeria",
                    OfficialName = "People's Democratic Republic of Algeria",
                    Tld = new[] { ".dz", "الجزائر." },
                    CountryCode = CountryCode.Dz,
                    IsoNumeric = "012",
                    Iso3 = CountryCodeIso3.Dza,
                    Cioc = "ALG",
                    Currencies = new[] { "DZD" },
                    CallingCodes = new[] { "213" },
                    Capital = "Algiers",
                    AlternativeSpellings = new[] { "DZ", "Dzayer", "Algérie" },
                    Region = "Africa",
                    SubRegion = "Northern Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Tun, CountryCodeIso3.Lby, CountryCodeIso3.Ner, CountryCodeIso3.Esh, CountryCodeIso3.Mrt, CountryCodeIso3.Mli, CountryCodeIso3.Mar },
                    Landlocked = false,
                    Area = 2381741,
                };
            }
        }
        public static Country Ecuador
        {
            get
            {
                return new Country
                {
                    CommonName = "Ecuador",
                    OfficialName = "Republic of Ecuador",
                    Tld = new[] { ".ec" },
                    CountryCode = CountryCode.Ec,
                    IsoNumeric = "218",
                    Iso3 = CountryCodeIso3.Ecu,
                    Cioc = "ECU",
                    Currencies = new[] { "USD" },
                    CallingCodes = new[] { "593" },
                    Capital = "Quito",
                    AlternativeSpellings = new[] { "EC", "Republic of Ecuador", "República del Ecuador" },
                    Region = "Americas",
                    SubRegion = "South America",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Col, CountryCodeIso3.Per },
                    Landlocked = false,
                    Area = 276841,
                };
            }
        }
        public static Country Egypt
        {
            get
            {
                return new Country
                {
                    CommonName = "Egypt",
                    OfficialName = "Arab Republic of Egypt",
                    Tld = new[] { ".eg", ".مصر" },
                    CountryCode = CountryCode.Eg,
                    IsoNumeric = "818",
                    Iso3 = CountryCodeIso3.Egy,
                    Cioc = "EGY",
                    Currencies = new[] { "EGP" },
                    CallingCodes = new[] { "20" },
                    Capital = "Cairo",
                    AlternativeSpellings = new[] { "EG", "Arab Republic of Egypt" },
                    Region = "Africa",
                    SubRegion = "Northern Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Isr, CountryCodeIso3.Lby, CountryCodeIso3.Sdn },
                    Landlocked = false,
                    Area = 1002450,
                };
            }
        }
        public static Country Eritrea
        {
            get
            {
                return new Country
                {
                    CommonName = "Eritrea",
                    OfficialName = "State of Eritrea",
                    Tld = new[] { ".er" },
                    CountryCode = CountryCode.Er,
                    IsoNumeric = "232",
                    Iso3 = CountryCodeIso3.Eri,
                    Cioc = "ERI",
                    Currencies = new[] { "ERN" },
                    CallingCodes = new[] { "291" },
                    Capital = "Asmara",
                    AlternativeSpellings = new[] { "ER", "State of Eritrea", "ሃገረ ኤርትራ", "Dawlat Iritriyá", "ʾErtrā", "Iritriyā", "" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Dji, CountryCodeIso3.Eth, CountryCodeIso3.Sdn },
                    Landlocked = false,
                    Area = 117600,
                };
            }
        }
        public static Country WesternSahara
        {
            get
            {
                return new Country
                {
                    CommonName = "Western Sahara",
                    OfficialName = "Sahrawi Arab Democratic Republic",
                    Tld = new[] { ".eh" },
                    CountryCode = CountryCode.Eh,
                    IsoNumeric = "732",
                    Iso3 = CountryCodeIso3.Esh,
                    Cioc = "",
                    Currencies = new[] { "MAD", "DZD", "MRO" },
                    CallingCodes = new[] { "212" },
                    Capital = "El Aaiún",
                    AlternativeSpellings = new[] { "EH", "Taneẓroft Tutrimt" },
                    Region = "Africa",
                    SubRegion = "Northern Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Dza, CountryCodeIso3.Mrt, CountryCodeIso3.Mar },
                    Landlocked = false,
                    Area = 266000,
                };
            }
        }
        public static Country Spain
        {
            get
            {
                return new Country
                {
                    CommonName = "Spain",
                    OfficialName = "Kingdom of Spain",
                    Tld = new[] { ".es" },
                    CountryCode = CountryCode.Es,
                    IsoNumeric = "724",
                    Iso3 = CountryCodeIso3.Esp,
                    Cioc = "ESP",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "34" },
                    Capital = "Madrid",
                    AlternativeSpellings = new[] { "ES", "Kingdom of Spain", "Reino de España" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.And, CountryCodeIso3.Fra, CountryCodeIso3.Gib, CountryCodeIso3.Prt, CountryCodeIso3.Mar },
                    Landlocked = false,
                    Area = 505992,
                };
            }
        }
        public static Country Estonia
        {
            get
            {
                return new Country
                {
                    CommonName = "Estonia",
                    OfficialName = "Republic of Estonia",
                    Tld = new[] { ".ee" },
                    CountryCode = CountryCode.Ee,
                    IsoNumeric = "233",
                    Iso3 = CountryCodeIso3.Est,
                    Cioc = "EST",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "372" },
                    Capital = "Tallinn",
                    AlternativeSpellings = new[] { "EE", "Eesti", "Republic of Estonia", "Eesti Vabariik" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Lva, CountryCodeIso3.Rus },
                    Landlocked = false,
                    Area = 45227,
                };
            }
        }
        public static Country Ethiopia
        {
            get
            {
                return new Country
                {
                    CommonName = "Ethiopia",
                    OfficialName = "Federal Democratic Republic of Ethiopia",
                    Tld = new[] { ".et" },
                    CountryCode = CountryCode.Et,
                    IsoNumeric = "231",
                    Iso3 = CountryCodeIso3.Eth,
                    Cioc = "ETH",
                    Currencies = new[] { "ETB" },
                    CallingCodes = new[] { "251" },
                    Capital = "Addis Ababa",
                    AlternativeSpellings = new[] { "ET", "ʾĪtyōṗṗyā", "Federal Democratic Republic of Ethiopia", "የኢትዮጵያ ፌዴራላዊ ዲሞክራሲያዊ ሪፐብሊክ" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Dji, CountryCodeIso3.Eri, CountryCodeIso3.Ken, CountryCodeIso3.Som, CountryCodeIso3.Ssd, CountryCodeIso3.Sdn },
                    Landlocked = true,
                    Area = 1104300,
                };
            }
        }
        public static Country Finland
        {
            get
            {
                return new Country
                {
                    CommonName = "Finland",
                    OfficialName = "Republic of Finland",
                    Tld = new[] { ".fi" },
                    CountryCode = CountryCode.Fi,
                    IsoNumeric = "246",
                    Iso3 = CountryCodeIso3.Fin,
                    Cioc = "FIN",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "358" },
                    Capital = "Helsinki",
                    AlternativeSpellings = new[] { "FI", "Suomi", "Republic of Finland", "Suomen tasavalta", "Republiken Finland" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Nor, CountryCodeIso3.Swe, CountryCodeIso3.Rus },
                    Landlocked = false,
                    Area = 338424,
                };
            }
        }
        public static Country Fiji
        {
            get
            {
                return new Country
                {
                    CommonName = "Fiji",
                    OfficialName = "Republic of Fiji",
                    Tld = new[] { ".fj" },
                    CountryCode = CountryCode.Fj,
                    IsoNumeric = "242",
                    Iso3 = CountryCodeIso3.Fji,
                    Cioc = "FIJ",
                    Currencies = new[] { "FJD" },
                    CallingCodes = new[] { "679" },
                    Capital = "Suva",
                    AlternativeSpellings = new[] { "FJ", "Viti", "Republic of Fiji", "Matanitu ko Viti", "Fijī Gaṇarājya" },
                    Region = "Oceania",
                    SubRegion = "Melanesia",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 18272,
                };
            }
        }
        public static Country FalklandIslands
        {
            get
            {
                return new Country
                {
                    CommonName = "Falkland Islands",
                    OfficialName = "Falkland Islands",
                    Tld = new[] { ".fk" },
                    CountryCode = CountryCode.Fk,
                    IsoNumeric = "238",
                    Iso3 = CountryCodeIso3.Flk,
                    Cioc = "",
                    Currencies = new[] { "FKP" },
                    CallingCodes = new[] { "500" },
                    Capital = "Stanley",
                    AlternativeSpellings = new[] { "FK", "Islas Malvinas", "Falkland Islands (Malvinas)" },
                    Region = "Americas",
                    SubRegion = "South America",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 12173,
                };
            }
        }
        public static Country France
        {
            get
            {
                return new Country
                {
                    CommonName = "France",
                    OfficialName = "French Republic",
                    Tld = new[] { ".fr" },
                    CountryCode = CountryCode.Fr,
                    IsoNumeric = "250",
                    Iso3 = CountryCodeIso3.Fra,
                    Cioc = "FRA",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "33" },
                    Capital = "Paris",
                    AlternativeSpellings = new[] { "FR", "French Republic", "République française" },
                    Region = "Europe",
                    SubRegion = "Western Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.And, CountryCodeIso3.Bel, CountryCodeIso3.Deu, CountryCodeIso3.Ita, CountryCodeIso3.Lux, CountryCodeIso3.Mco, CountryCodeIso3.Esp, CountryCodeIso3.Che },
                    Landlocked = false,
                    Area = 551695,
                };
            }
        }
        public static Country FaroeIslands
        {
            get
            {
                return new Country
                {
                    CommonName = "Faroe Islands",
                    OfficialName = "Faroe Islands",
                    Tld = new[] { ".fo" },
                    CountryCode = CountryCode.Fo,
                    IsoNumeric = "234",
                    Iso3 = CountryCodeIso3.Fro,
                    Cioc = "",
                    Currencies = new[] { "DKK" },
                    CallingCodes = new[] { "298" },
                    Capital = "Tórshavn",
                    AlternativeSpellings = new[] { "FO", "Føroyar", "Færøerne" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 1393,
                };
            }
        }
        public static Country Micronesia
        {
            get
            {
                return new Country
                {
                    CommonName = "Micronesia",
                    OfficialName = "Federated States of Micronesia",
                    Tld = new[] { ".fm" },
                    CountryCode = CountryCode.Fm,
                    IsoNumeric = "583",
                    Iso3 = CountryCodeIso3.Fsm,
                    Cioc = "FSM",
                    Currencies = new[] { "USD" },
                    CallingCodes = new[] { "691" },
                    Capital = "Palikir",
                    AlternativeSpellings = new[] { "FM", "Federated States of Micronesia", "Micronesia, Federated States of" },
                    Region = "Oceania",
                    SubRegion = "Micronesia",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 702,
                };
            }
        }
        public static Country Gabon
        {
            get
            {
                return new Country
                {
                    CommonName = "Gabon",
                    OfficialName = "Gabonese Republic",
                    Tld = new[] { ".ga" },
                    CountryCode = CountryCode.Ga,
                    IsoNumeric = "266",
                    Iso3 = CountryCodeIso3.Gab,
                    Cioc = "GAB",
                    Currencies = new[] { "XAF" },
                    CallingCodes = new[] { "241" },
                    Capital = "Libreville",
                    AlternativeSpellings = new[] { "GA", "Gabonese Republic", "République Gabonaise" },
                    Region = "Africa",
                    SubRegion = "Middle Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Cmr, CountryCodeIso3.Cog, CountryCodeIso3.Gnq },
                    Landlocked = false,
                    Area = 267668,
                };
            }
        }
        public static Country UnitedKingdom
        {
            get
            {
                return new Country
                {
                    CommonName = "United Kingdom",
                    OfficialName = "United Kingdom of Great Britain and Northern Ireland",
                    Tld = new[] { ".uk" },
                    CountryCode = CountryCode.Uk,
                    IsoNumeric = "826",
                    Iso3 = CountryCodeIso3.Gbr,
                    Cioc = "GBR",
                    Currencies = new[] { "GBP" },
                    CallingCodes = new[] { "44" },
                    Capital = "London",
                    AlternativeSpellings = new[] { "GB", "UK", "Great Britain" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Irl },
                    Landlocked = false,
                    Area = 242900,
                };
            }
        }
        public static Country Georgia
        {
            get
            {
                return new Country
                {
                    CommonName = "Georgia",
                    OfficialName = "Georgia",
                    Tld = new[] { ".ge" },
                    CountryCode = CountryCode.Ge,
                    IsoNumeric = "268",
                    Iso3 = CountryCodeIso3.Geo,
                    Cioc = "GEO",
                    Currencies = new[] { "GEL" },
                    CallingCodes = new[] { "995" },
                    Capital = "Tbilisi",
                    AlternativeSpellings = new[] { "GE", "Sakartvelo" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Arm, CountryCodeIso3.Aze, CountryCodeIso3.Rus, CountryCodeIso3.Tur },
                    Landlocked = false,
                    Area = 69700,
                };
            }
        }
        public static Country Guernsey
        {
            get
            {
                return new Country
                {
                    CommonName = "Guernsey",
                    OfficialName = "Bailiwick of Guernsey",
                    Tld = new[] { ".gg" },
                    CountryCode = CountryCode.Gg,
                    IsoNumeric = "831",
                    Iso3 = CountryCodeIso3.Ggy,
                    Cioc = "",
                    Currencies = new[] { "GBP" },
                    CallingCodes = new[] { "44" },
                    Capital = "St. Peter Port",
                    AlternativeSpellings = new[] { "GG", "Bailiwick of Guernsey", "Bailliage de Guernesey" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 78,
                };
            }
        }
        public static Country Ghana
        {
            get
            {
                return new Country
                {
                    CommonName = "Ghana",
                    OfficialName = "Republic of Ghana",
                    Tld = new[] { ".gh" },
                    CountryCode = CountryCode.Gh,
                    IsoNumeric = "288",
                    Iso3 = CountryCodeIso3.Gha,
                    Cioc = "GHA",
                    Currencies = new[] { "GHS" },
                    CallingCodes = new[] { "233" },
                    Capital = "Accra",
                    AlternativeSpellings = new[] { "GH" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Bfa, CountryCodeIso3.Civ, CountryCodeIso3.Tgo },
                    Landlocked = false,
                    Area = 238533,
                };
            }
        }
        public static Country Gibraltar
        {
            get
            {
                return new Country
                {
                    CommonName = "Gibraltar",
                    OfficialName = "Gibraltar",
                    Tld = new[] { ".gi" },
                    CountryCode = CountryCode.Gi,
                    IsoNumeric = "292",
                    Iso3 = CountryCodeIso3.Gib,
                    Cioc = "",
                    Currencies = new[] { "GIP" },
                    CallingCodes = new[] { "350" },
                    Capital = "Gibraltar",
                    AlternativeSpellings = new[] { "GI" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Esp },
                    Landlocked = false,
                    Area = 6,
                };
            }
        }
        public static Country Guinea
        {
            get
            {
                return new Country
                {
                    CommonName = "Guinea",
                    OfficialName = "Republic of Guinea",
                    Tld = new[] { ".gn" },
                    CountryCode = CountryCode.Gn,
                    IsoNumeric = "324",
                    Iso3 = CountryCodeIso3.Gin,
                    Cioc = "GUI",
                    Currencies = new[] { "GNF" },
                    CallingCodes = new[] { "224" },
                    Capital = "Conakry",
                    AlternativeSpellings = new[] { "GN", "Republic of Guinea", "République de Guinée" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Civ, CountryCodeIso3.Gnb, CountryCodeIso3.Lbr, CountryCodeIso3.Mli, CountryCodeIso3.Sen, CountryCodeIso3.Sle },
                    Landlocked = false,
                    Area = 245857,
                };
            }
        }
        public static Country Guadeloupe
        {
            get
            {
                return new Country
                {
                    CommonName = "Guadeloupe",
                    OfficialName = "Guadeloupe",
                    Tld = new[] { ".gp" },
                    CountryCode = CountryCode.Gp,
                    IsoNumeric = "312",
                    Iso3 = CountryCodeIso3.Glp,
                    Cioc = "",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "590" },
                    Capital = "Basse-Terre",
                    AlternativeSpellings = new[] { "GP", "Gwadloup" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 1628,
                };
            }
        }
        public static Country Gambia
        {
            get
            {
                return new Country
                {
                    CommonName = "Gambia",
                    OfficialName = "Republic of the Gambia",
                    Tld = new[] { ".gm" },
                    CountryCode = CountryCode.Gm,
                    IsoNumeric = "270",
                    Iso3 = CountryCodeIso3.Gmb,
                    Cioc = "GAM",
                    Currencies = new[] { "GMD" },
                    CallingCodes = new[] { "220" },
                    Capital = "Banjul",
                    AlternativeSpellings = new[] { "GM", "Republic of the Gambia" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Sen },
                    Landlocked = false,
                    Area = 10689,
                };
            }
        }
        public static Country GuineaBissau
        {
            get
            {
                return new Country
                {
                    CommonName = "Guinea-Bissau",
                    OfficialName = "Republic of Guinea-Bissau",
                    Tld = new[] { ".gw" },
                    CountryCode = CountryCode.Gw,
                    IsoNumeric = "624",
                    Iso3 = CountryCodeIso3.Gnb,
                    Cioc = "GBS",
                    Currencies = new[] { "XOF" },
                    CallingCodes = new[] { "245" },
                    Capital = "Bissau",
                    AlternativeSpellings = new[] { "GW", "Republic of Guinea-Bissau", "República da Guiné-Bissau" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Gin, CountryCodeIso3.Sen },
                    Landlocked = false,
                    Area = 36125,
                };
            }
        }
        public static Country EquatorialGuinea
        {
            get
            {
                return new Country
                {
                    CommonName = "Equatorial Guinea",
                    OfficialName = "Republic of Equatorial Guinea",
                    Tld = new[] { ".gq" },
                    CountryCode = CountryCode.Gq,
                    IsoNumeric = "226",
                    Iso3 = CountryCodeIso3.Gnq,
                    Cioc = "GEQ",
                    Currencies = new[] { "XAF" },
                    CallingCodes = new[] { "240" },
                    Capital = "Malabo",
                    AlternativeSpellings = new[] { "GQ", "Republic of Equatorial Guinea", "República de Guinea Ecuatorial", "République de Guinée équatoriale", "República da Guiné Equatorial" },
                    Region = "Africa",
                    SubRegion = "Middle Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Cmr, CountryCodeIso3.Gab },
                    Landlocked = false,
                    Area = 28051,
                };
            }
        }
        public static Country Greece
        {
            get
            {
                return new Country
                {
                    CommonName = "Greece",
                    OfficialName = "Hellenic Republic",
                    Tld = new[] { ".gr" },
                    CountryCode = CountryCode.Gr,
                    IsoNumeric = "300",
                    Iso3 = CountryCodeIso3.Grc,
                    Cioc = "GRE",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "30" },
                    Capital = "Athens",
                    AlternativeSpellings = new[] { "GR", "Elláda", "Hellenic Republic", "Ελληνική Δημοκρατία" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Alb, CountryCodeIso3.Bgr, CountryCodeIso3.Tur, CountryCodeIso3.Mkd },
                    Landlocked = false,
                    Area = 131990,
                };
            }
        }
        public static Country Grenada
        {
            get
            {
                return new Country
                {
                    CommonName = "Grenada",
                    OfficialName = "Grenada",
                    Tld = new[] { ".gd" },
                    CountryCode = CountryCode.Gd,
                    IsoNumeric = "308",
                    Iso3 = CountryCodeIso3.Grd,
                    Cioc = "GRN",
                    Currencies = new[] { "XCD" },
                    CallingCodes = new[] { "1473" },
                    Capital = "St. George's",
                    AlternativeSpellings = new[] { "GD" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 344,
                };
            }
        }
        public static Country Greenland
        {
            get
            {
                return new Country
                {
                    CommonName = "Greenland",
                    OfficialName = "Greenland",
                    Tld = new[] { ".gl" },
                    CountryCode = CountryCode.Gl,
                    IsoNumeric = "304",
                    Iso3 = CountryCodeIso3.Grl,
                    Cioc = "",
                    Currencies = new[] { "DKK" },
                    CallingCodes = new[] { "299" },
                    Capital = "Nuuk",
                    AlternativeSpellings = new[] { "GL", "Grønland" },
                    Region = "Americas",
                    SubRegion = "Northern America",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 2166086,
                };
            }
        }
        public static Country Guatemala
        {
            get
            {
                return new Country
                {
                    CommonName = "Guatemala",
                    OfficialName = "Republic of Guatemala",
                    Tld = new[] { ".gt" },
                    CountryCode = CountryCode.Gt,
                    IsoNumeric = "320",
                    Iso3 = CountryCodeIso3.Gtm,
                    Cioc = "GUA",
                    Currencies = new[] { "GTQ" },
                    CallingCodes = new[] { "502" },
                    Capital = "Guatemala City",
                    AlternativeSpellings = new[] { "GT" },
                    Region = "Americas",
                    SubRegion = "Central America",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Blz, CountryCodeIso3.Slv, CountryCodeIso3.Hnd, CountryCodeIso3.Mex },
                    Landlocked = false,
                    Area = 108889,
                };
            }
        }
        public static Country FrenchGuiana
        {
            get
            {
                return new Country
                {
                    CommonName = "French Guiana",
                    OfficialName = "Guiana",
                    Tld = new[] { ".gf" },
                    CountryCode = CountryCode.Gf,
                    IsoNumeric = "254",
                    Iso3 = CountryCodeIso3.Guf,
                    Cioc = "",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "594" },
                    Capital = "Cayenne",
                    AlternativeSpellings = new[] { "GF", "Guiana", "Guyane" },
                    Region = "Americas",
                    SubRegion = "South America",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Bra, CountryCodeIso3.Sur },
                    Landlocked = false,
                    Area = 83534,
                };
            }
        }
        public static Country Guam
        {
            get
            {
                return new Country
                {
                    CommonName = "Guam",
                    OfficialName = "Guam",
                    Tld = new[] { ".gu" },
                    CountryCode = CountryCode.Gu,
                    IsoNumeric = "316",
                    Iso3 = CountryCodeIso3.Gum,
                    Cioc = "GUM",
                    Currencies = new[] { "USD" },
                    CallingCodes = new[] { "1671" },
                    Capital = "Hagåtña",
                    AlternativeSpellings = new[] { "GU", "Guåhån" },
                    Region = "Oceania",
                    SubRegion = "Micronesia",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 549,
                };
            }
        }
        public static Country Guyana
        {
            get
            {
                return new Country
                {
                    CommonName = "Guyana",
                    OfficialName = "Co-operative Republic of Guyana",
                    Tld = new[] { ".gy" },
                    CountryCode = CountryCode.Gy,
                    IsoNumeric = "328",
                    Iso3 = CountryCodeIso3.Guy,
                    Cioc = "GUY",
                    Currencies = new[] { "GYD" },
                    CallingCodes = new[] { "592" },
                    Capital = "Georgetown",
                    AlternativeSpellings = new[] { "GY", "Co-operative Republic of Guyana" },
                    Region = "Americas",
                    SubRegion = "South America",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Bra, CountryCodeIso3.Sur, CountryCodeIso3.Ven },
                    Landlocked = false,
                    Area = 214969,
                };
            }
        }
        public static Country HongKong
        {
            get
            {
                return new Country
                {
                    CommonName = "Hong Kong",
                    OfficialName = "Hong Kong Special Administrative Region of the People's Republic of China",
                    Tld = new[] { ".hk", ".香港" },
                    CountryCode = CountryCode.Hk,
                    IsoNumeric = "344",
                    Iso3 = CountryCodeIso3.Hkg,
                    Cioc = "HKG",
                    Currencies = new[] { "HKD" },
                    CallingCodes = new[] { "852" },
                    Capital = "City of Victoria",
                    AlternativeSpellings = new[] { "HK" },
                    Region = "Asia",
                    SubRegion = "Eastern Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Chn },
                    Landlocked = false,
                    Area = 1104,
                };
            }
        }
        public static Country HeardIslandandMcDonaldIslands
        {
            get
            {
                return new Country
                {
                    CommonName = "Heard Island and McDonald Islands",
                    OfficialName = "Heard Island and McDonald Islands",
                    Tld = new[] { ".hm", ".aq" },
                    CountryCode = CountryCode.Hm,
                    IsoNumeric = "334",
                    Iso3 = CountryCodeIso3.Hmd,
                    Cioc = "",
                    Currencies = new[] { "AUD" },
                    Capital = "",
                    AlternativeSpellings = new[] { "HM", "Heard Island and McDonald Mcdonald Islands" },
                    Region = "",
                    SubRegion = "",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 412,
                };
            }
        }
        public static Country Honduras
        {
            get
            {
                return new Country
                {
                    CommonName = "Honduras",
                    OfficialName = "Republic of Honduras",
                    Tld = new[] { ".hn" },
                    CountryCode = CountryCode.Hn,
                    IsoNumeric = "340",
                    Iso3 = CountryCodeIso3.Hnd,
                    Cioc = "HON",
                    Currencies = new[] { "HNL" },
                    CallingCodes = new[] { "504" },
                    Capital = "Tegucigalpa",
                    AlternativeSpellings = new[] { "HN", "Republic of Honduras", "República de Honduras" },
                    Region = "Americas",
                    SubRegion = "Central America",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Gtm, CountryCodeIso3.Slv, CountryCodeIso3.Nic },
                    Landlocked = false,
                    Area = 112492,
                };
            }
        }
        public static Country Croatia
        {
            get
            {
                return new Country
                {
                    CommonName = "Croatia",
                    OfficialName = "Republic of Croatia",
                    Tld = new[] { ".hr" },
                    CountryCode = CountryCode.Hr,
                    IsoNumeric = "191",
                    Iso3 = CountryCodeIso3.Hrv,
                    Cioc = "CRO",
                    Currencies = new[] { "HRK" },
                    CallingCodes = new[] { "385" },
                    Capital = "Zagreb",
                    AlternativeSpellings = new[] { "HR", "Hrvatska", "Republic of Croatia", "Republika Hrvatska" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Bih, CountryCodeIso3.Hun, CountryCodeIso3.Mne, CountryCodeIso3.Srb, CountryCodeIso3.Svn },
                    Landlocked = false,
                    Area = 56594,
                };
            }
        }
        public static Country Haiti
        {
            get
            {
                return new Country
                {
                    CommonName = "Haiti",
                    OfficialName = "Republic of Haiti",
                    Tld = new[] { ".ht" },
                    CountryCode = CountryCode.Ht,
                    IsoNumeric = "332",
                    Iso3 = CountryCodeIso3.Hti,
                    Cioc = "HAI",
                    Currencies = new[] { "HTG", "USD" },
                    CallingCodes = new[] { "509" },
                    Capital = "Port-au-Prince",
                    AlternativeSpellings = new[] { "HT", "Republic of Haiti", "République d'Haïti", "Repiblik Ayiti" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Dom },
                    Landlocked = false,
                    Area = 27750,
                };
            }
        }
        public static Country Hungary
        {
            get
            {
                return new Country
                {
                    CommonName = "Hungary",
                    OfficialName = "Hungary",
                    Tld = new[] { ".hu" },
                    CountryCode = CountryCode.Hu,
                    IsoNumeric = "348",
                    Iso3 = CountryCodeIso3.Hun,
                    Cioc = "HUN",
                    Currencies = new[] { "HUF" },
                    CallingCodes = new[] { "36" },
                    Capital = "Budapest",
                    AlternativeSpellings = new[] { "HU" },
                    Region = "Europe",
                    SubRegion = "Eastern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Aut, CountryCodeIso3.Hrv, CountryCodeIso3.Rou, CountryCodeIso3.Srb, CountryCodeIso3.Svk, CountryCodeIso3.Svn, CountryCodeIso3.Ukr },
                    Landlocked = true,
                    Area = 93028,
                };
            }
        }
        public static Country Indonesia
        {
            get
            {
                return new Country
                {
                    CommonName = "Indonesia",
                    OfficialName = "Republic of Indonesia",
                    Tld = new[] { ".id" },
                    CountryCode = CountryCode.Id,
                    IsoNumeric = "360",
                    Iso3 = CountryCodeIso3.Idn,
                    Cioc = "INA",
                    Currencies = new[] { "IDR" },
                    CallingCodes = new[] { "62" },
                    Capital = "Jakarta",
                    AlternativeSpellings = new[] { "ID", "Republic of Indonesia", "Republik Indonesia" },
                    Region = "Asia",
                    SubRegion = "South-Eastern Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Tls, CountryCodeIso3.Mys, CountryCodeIso3.Png },
                    Landlocked = false,
                    Area = 1904569,
                };
            }
        }
        public static Country IsleofMan
        {
            get
            {
                return new Country
                {
                    CommonName = "Isle of Man",
                    OfficialName = "Isle of Man",
                    Tld = new[] { ".im" },
                    CountryCode = CountryCode.Im,
                    IsoNumeric = "833",
                    Iso3 = CountryCodeIso3.Imn,
                    Cioc = "",
                    Currencies = new[] { "GBP" },
                    CallingCodes = new[] { "44" },
                    Capital = "Douglas",
                    AlternativeSpellings = new[] { "IM", "Ellan Vannin", "Mann", "Mannin" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 572,
                };
            }
        }
        public static Country India
        {
            get
            {
                return new Country
                {
                    CommonName = "India",
                    OfficialName = "Republic of India",
                    Tld = new[] { ".in" },
                    CountryCode = CountryCode.In,
                    IsoNumeric = "356",
                    Iso3 = CountryCodeIso3.Ind,
                    Cioc = "IND",
                    Currencies = new[] { "INR" },
                    CallingCodes = new[] { "91" },
                    Capital = "New Delhi",
                    AlternativeSpellings = new[] { "IN", "Bhārat", "Republic of India", "Bharat Ganrajya", "இந்தியா" },
                    Region = "Asia",
                    SubRegion = "Southern Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Afg, CountryCodeIso3.Bgd, CountryCodeIso3.Btn, CountryCodeIso3.Mmr, CountryCodeIso3.Chn, CountryCodeIso3.Npl, CountryCodeIso3.Pak, CountryCodeIso3.Lka },
                    Landlocked = false,
                    Area = 3287590,
                };
            }
        }
        public static Country BritishIndianOceanTerritory
        {
            get
            {
                return new Country
                {
                    CommonName = "British Indian Ocean Territory",
                    OfficialName = "British Indian Ocean Territory",
                    Tld = new[] { ".io" },
                    CountryCode = CountryCode.Io,
                    IsoNumeric = "086",
                    Iso3 = CountryCodeIso3.Iot,
                    Cioc = "",
                    Currencies = new[] { "USD" },
                    CallingCodes = new[] { "246" },
                    Capital = "Diego Garcia",
                    AlternativeSpellings = new[] { "IO" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 60,
                };
            }
        }
        public static Country Ireland
        {
            get
            {
                return new Country
                {
                    CommonName = "Ireland",
                    OfficialName = "Republic of Ireland",
                    Tld = new[] { ".ie" },
                    CountryCode = CountryCode.Ie,
                    IsoNumeric = "372",
                    Iso3 = CountryCodeIso3.Irl,
                    Cioc = "IRL",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "353" },
                    Capital = "Dublin",
                    AlternativeSpellings = new[] { "IE", "Éire", "Republic of Ireland", "Poblacht na hÉireann" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Gbr },
                    Landlocked = false,
                    Area = 70273,
                };
            }
        }
        public static Country Iran
        {
            get
            {
                return new Country
                {
                    CommonName = "Iran",
                    OfficialName = "Islamic Republic of Iran",
                    Tld = new[] { ".ir", "ایران." },
                    CountryCode = CountryCode.Ir,
                    IsoNumeric = "364",
                    Iso3 = CountryCodeIso3.Irn,
                    Cioc = "IRI",
                    Currencies = new[] { "IRR" },
                    CallingCodes = new[] { "98" },
                    Capital = "Tehran",
                    AlternativeSpellings = new[] { "IR", "Islamic Republic of Iran", "Iran, Islamic Republic of", "Jomhuri-ye Eslāmi-ye Irān" },
                    Region = "Asia",
                    SubRegion = "Southern Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Afg, CountryCodeIso3.Arm, CountryCodeIso3.Aze, CountryCodeIso3.Irq, CountryCodeIso3.Pak, CountryCodeIso3.Tur, CountryCodeIso3.Tkm },
                    Landlocked = false,
                    Area = 1648195,
                };
            }
        }
        public static Country Iraq
        {
            get
            {
                return new Country
                {
                    CommonName = "Iraq",
                    OfficialName = "Republic of Iraq",
                    Tld = new[] { ".iq" },
                    CountryCode = CountryCode.Iq,
                    IsoNumeric = "368",
                    Iso3 = CountryCodeIso3.Irq,
                    Cioc = "IRQ",
                    Currencies = new[] { "IQD" },
                    CallingCodes = new[] { "964" },
                    Capital = "Baghdad",
                    AlternativeSpellings = new[] { "IQ", "Republic of Iraq", "Jumhūriyyat al-‘Irāq" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Irn, CountryCodeIso3.Jor, CountryCodeIso3.Kwt, CountryCodeIso3.Sau, CountryCodeIso3.Syr, CountryCodeIso3.Tur },
                    Landlocked = false,
                    Area = 438317,
                };
            }
        }
        public static Country Iceland
        {
            get
            {
                return new Country
                {
                    CommonName = "Iceland",
                    OfficialName = "Iceland",
                    Tld = new[] { ".is" },
                    CountryCode = CountryCode.Is,
                    IsoNumeric = "352",
                    Iso3 = CountryCodeIso3.Isl,
                    Cioc = "ISL",
                    Currencies = new[] { "ISK" },
                    CallingCodes = new[] { "354" },
                    Capital = "Reykjavik",
                    AlternativeSpellings = new[] { "IS", "Island", "Republic of Iceland", "Lýðveldið Ísland" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 103000,
                };
            }
        }
        public static Country Israel
        {
            get
            {
                return new Country
                {
                    CommonName = "Israel",
                    OfficialName = "State of Israel",
                    Tld = new[] { ".il" },
                    CountryCode = CountryCode.Il,
                    IsoNumeric = "376",
                    Iso3 = CountryCodeIso3.Isr,
                    Cioc = "ISR",
                    Currencies = new[] { "ILS" },
                    CallingCodes = new[] { "972" },
                    Capital = "Jerusalem",
                    AlternativeSpellings = new[] { "IL", "State of Israel", "Medīnat Yisrā'el" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Egy, CountryCodeIso3.Jor, CountryCodeIso3.Lbn, CountryCodeIso3.Syr },
                    Landlocked = false,
                    Area = 20770,
                };
            }
        }
        public static Country Italy
        {
            get
            {
                return new Country
                {
                    CommonName = "Italy",
                    OfficialName = "Italian Republic",
                    Tld = new[] { ".it" },
                    CountryCode = CountryCode.It,
                    IsoNumeric = "380",
                    Iso3 = CountryCodeIso3.Ita,
                    Cioc = "ITA",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "39" },
                    Capital = "Rome",
                    AlternativeSpellings = new[] { "IT", "Italian Republic", "Repubblica italiana" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Aut, CountryCodeIso3.Fra, CountryCodeIso3.Smr, CountryCodeIso3.Svn, CountryCodeIso3.Che, CountryCodeIso3.Vat },
                    Landlocked = false,
                    Area = 301336,
                };
            }
        }
        public static Country Jamaica
        {
            get
            {
                return new Country
                {
                    CommonName = "Jamaica",
                    OfficialName = "Jamaica",
                    Tld = new[] { ".jm" },
                    CountryCode = CountryCode.Jm,
                    IsoNumeric = "388",
                    Iso3 = CountryCodeIso3.Jam,
                    Cioc = "JAM",
                    Currencies = new[] { "JMD" },
                    CallingCodes = new[] { "1876" },
                    Capital = "Kingston",
                    AlternativeSpellings = new[] { "JM" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 10991,
                };
            }
        }
        public static Country Jersey
        {
            get
            {
                return new Country
                {
                    CommonName = "Jersey",
                    OfficialName = "Bailiwick of Jersey",
                    Tld = new[] { ".je" },
                    CountryCode = CountryCode.Je,
                    IsoNumeric = "832",
                    Iso3 = CountryCodeIso3.Jey,
                    Cioc = "",
                    Currencies = new[] { "GBP" },
                    CallingCodes = new[] { "44" },
                    Capital = "Saint Helier",
                    AlternativeSpellings = new[] { "JE", "Bailiwick of Jersey", "Bailliage de Jersey", "Bailliage dé Jèrri" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 116,
                };
            }
        }
        public static Country Jordan
        {
            get
            {
                return new Country
                {
                    CommonName = "Jordan",
                    OfficialName = "Hashemite Kingdom of Jordan",
                    Tld = new[] { ".jo", "الاردن." },
                    CountryCode = CountryCode.Jo,
                    IsoNumeric = "400",
                    Iso3 = CountryCodeIso3.Jor,
                    Cioc = "JOR",
                    Currencies = new[] { "JOD" },
                    CallingCodes = new[] { "962" },
                    Capital = "Amman",
                    AlternativeSpellings = new[] { "JO", "Hashemite Kingdom of Jordan", "al-Mamlakah al-Urdunīyah al-Hāshimīyah" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Irq, CountryCodeIso3.Isr, CountryCodeIso3.Sau, CountryCodeIso3.Syr },
                    Landlocked = false,
                    Area = 89342,
                };
            }
        }
        public static Country Japan
        {
            get
            {
                return new Country
                {
                    CommonName = "Japan",
                    OfficialName = "Japan",
                    Tld = new[] { ".jp", ".みんな" },
                    CountryCode = CountryCode.Jp,
                    IsoNumeric = "392",
                    Iso3 = CountryCodeIso3.Jpn,
                    Cioc = "JPN",
                    Currencies = new[] { "JPY" },
                    CallingCodes = new[] { "81" },
                    Capital = "Tokyo",
                    AlternativeSpellings = new[] { "JP", "Nippon", "Nihon" },
                    Region = "Asia",
                    SubRegion = "Eastern Asia",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 377930,
                };
            }
        }
        public static Country Kazakhstan
        {
            get
            {
                return new Country
                {
                    CommonName = "Kazakhstan",
                    OfficialName = "Republic of Kazakhstan",
                    Tld = new[] { ".kz", ".қаз" },
                    CountryCode = CountryCode.Kz,
                    IsoNumeric = "398",
                    Iso3 = CountryCodeIso3.Kaz,
                    Cioc = "KAZ",
                    Currencies = new[] { "KZT" },
                    CallingCodes = new[] { "76", "77" },
                    Capital = "Astana",
                    AlternativeSpellings = new[] { "KZ", "Qazaqstan", "Казахстан", "Republic of Kazakhstan", "Қазақстан Республикасы", "Qazaqstan Respublïkası", "Республика Казахстан", "Respublika Kazakhstan" },
                    Region = "Asia",
                    SubRegion = "Central Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Chn, CountryCodeIso3.Kgz, CountryCodeIso3.Rus, CountryCodeIso3.Tkm, CountryCodeIso3.Uzb },
                    Landlocked = true,
                    Area = 2724900,
                };
            }
        }
        public static Country Kenya
        {
            get
            {
                return new Country
                {
                    CommonName = "Kenya",
                    OfficialName = "Republic of Kenya",
                    Tld = new[] { ".ke" },
                    CountryCode = CountryCode.Ke,
                    IsoNumeric = "404",
                    Iso3 = CountryCodeIso3.Ken,
                    Cioc = "KEN",
                    Currencies = new[] { "KES" },
                    CallingCodes = new[] { "254" },
                    Capital = "Nairobi",
                    AlternativeSpellings = new[] { "KE", "Republic of Kenya", "Jamhuri ya Kenya" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Eth, CountryCodeIso3.Som, CountryCodeIso3.Ssd, CountryCodeIso3.Tza, CountryCodeIso3.Uga },
                    Landlocked = false,
                    Area = 580367,
                };
            }
        }
        public static Country Kyrgyzstan
        {
            get
            {
                return new Country
                {
                    CommonName = "Kyrgyzstan",
                    OfficialName = "Kyrgyz Republic",
                    Tld = new[] { ".kg" },
                    CountryCode = CountryCode.Kg,
                    IsoNumeric = "417",
                    Iso3 = CountryCodeIso3.Kgz,
                    Cioc = "KGZ",
                    Currencies = new[] { "KGS" },
                    CallingCodes = new[] { "996" },
                    Capital = "Bishkek",
                    AlternativeSpellings = new[] { "KG", "Киргизия", "Kyrgyz Republic", "Кыргыз Республикасы", "Kyrgyz Respublikasy" },
                    Region = "Asia",
                    SubRegion = "Central Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Chn, CountryCodeIso3.Kaz, CountryCodeIso3.Tjk, CountryCodeIso3.Uzb },
                    Landlocked = true,
                    Area = 199951,
                };
            }
        }
        public static Country Cambodia
        {
            get
            {
                return new Country
                {
                    CommonName = "Cambodia",
                    OfficialName = "Kingdom of Cambodia",
                    Tld = new[] { ".kh" },
                    CountryCode = CountryCode.Kh,
                    IsoNumeric = "116",
                    Iso3 = CountryCodeIso3.Khm,
                    Cioc = "CAM",
                    Currencies = new[] { "KHR" },
                    CallingCodes = new[] { "855" },
                    Capital = "Phnom Penh",
                    AlternativeSpellings = new[] { "KH", "Kingdom of Cambodia" },
                    Region = "Asia",
                    SubRegion = "South-Eastern Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Lao, CountryCodeIso3.Tha, CountryCodeIso3.Vnm },
                    Landlocked = false,
                    Area = 181035,
                };
            }
        }
        public static Country Kiribati
        {
            get
            {
                return new Country
                {
                    CommonName = "Kiribati",
                    OfficialName = "Independent and Sovereign Republic of Kiribati",
                    Tld = new[] { ".ki" },
                    CountryCode = CountryCode.Ki,
                    IsoNumeric = "296",
                    Iso3 = CountryCodeIso3.Kir,
                    Cioc = "KIR",
                    Currencies = new[] { "AUD" },
                    CallingCodes = new[] { "686" },
                    Capital = "South Tarawa",
                    AlternativeSpellings = new[] { "KI", "Republic of Kiribati", "Ribaberiki Kiribati" },
                    Region = "Oceania",
                    SubRegion = "Micronesia",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 811,
                };
            }
        }
        public static Country SaintKittsandNevis
        {
            get
            {
                return new Country
                {
                    CommonName = "Saint Kitts and Nevis",
                    OfficialName = "Federation of Saint Christopher and Nevisa",
                    Tld = new[] { ".kn" },
                    CountryCode = CountryCode.Kn,
                    IsoNumeric = "659",
                    Iso3 = CountryCodeIso3.Kna,
                    Cioc = "SKN",
                    Currencies = new[] { "XCD" },
                    CallingCodes = new[] { "1869" },
                    Capital = "Basseterre",
                    AlternativeSpellings = new[] { "KN", "Federation of Saint Christopher and Nevis" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 261,
                };
            }
        }
        public static Country SouthKorea
        {
            get
            {
                return new Country
                {
                    CommonName = "South Korea",
                    OfficialName = "Republic of Korea",
                    Tld = new[] { ".kr", ".한국" },
                    CountryCode = CountryCode.Kr,
                    IsoNumeric = "410",
                    Iso3 = CountryCodeIso3.Kor,
                    Cioc = "KOR",
                    Currencies = new[] { "KRW" },
                    CallingCodes = new[] { "82" },
                    Capital = "Seoul",
                    AlternativeSpellings = new[] { "KR", "Korea, Republic of", "Republic of Korea" },
                    Region = "Asia",
                    SubRegion = "Eastern Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Prk },
                    Landlocked = false,
                    Area = 100210,
                };
            }
        }
        public static Country Kosovo
        {
            get
            {
                return new Country
                {
                    CommonName = "Kosovo",
                    OfficialName = "Republic of Kosovo",
                    Tld = new string[] { },
                    CountryCode = CountryCode.Xk,
                    IsoNumeric = "",
                    Iso3 = CountryCodeIso3.Kos,
                    Cioc = "KOS",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "383" },
                    Capital = "Pristina",
                    AlternativeSpellings = new[] { "XK", "Република Косово" },
                    Region = "Europe",
                    SubRegion = "Eastern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Alb, CountryCodeIso3.Mkd, CountryCodeIso3.Mne, CountryCodeIso3.Srb },
                    Landlocked = true,
                    Area = 10908,
                };
            }
        }
        public static Country Kuwait
        {
            get
            {
                return new Country
                {
                    CommonName = "Kuwait",
                    OfficialName = "State of Kuwait",
                    Tld = new[] { ".kw" },
                    CountryCode = CountryCode.Kw,
                    IsoNumeric = "414",
                    Iso3 = CountryCodeIso3.Kwt,
                    Cioc = "KUW",
                    Currencies = new[] { "KWD" },
                    CallingCodes = new[] { "965" },
                    Capital = "Kuwait City",
                    AlternativeSpellings = new[] { "KW", "State of Kuwait", "Dawlat al-Kuwait" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Irq, CountryCodeIso3.Sau },
                    Landlocked = false,
                    Area = 17818,
                };
            }
        }
        public static Country Laos
        {
            get
            {
                return new Country
                {
                    CommonName = "Laos",
                    OfficialName = "Lao People's Democratic Republic",
                    Tld = new[] { ".la" },
                    CountryCode = CountryCode.La,
                    IsoNumeric = "418",
                    Iso3 = CountryCodeIso3.Lao,
                    Cioc = "LAO",
                    Currencies = new[] { "LAK" },
                    CallingCodes = new[] { "856" },
                    Capital = "Vientiane",
                    AlternativeSpellings = new[] { "LA", "Lao", "Lao People's Democratic Republic", "Sathalanalat Paxathipatai Paxaxon Lao" },
                    Region = "Asia",
                    SubRegion = "South-Eastern Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Mmr, CountryCodeIso3.Khm, CountryCodeIso3.Chn, CountryCodeIso3.Tha, CountryCodeIso3.Vnm },
                    Landlocked = true,
                    Area = 236800,
                };
            }
        }
        public static Country Lebanon
        {
            get
            {
                return new Country
                {
                    CommonName = "Lebanon",
                    OfficialName = "Lebanese Republic",
                    Tld = new[] { ".lb" },
                    CountryCode = CountryCode.Lb,
                    IsoNumeric = "422",
                    Iso3 = CountryCodeIso3.Lbn,
                    Cioc = "LIB",
                    Currencies = new[] { "LBP" },
                    CallingCodes = new[] { "961" },
                    Capital = "Beirut",
                    AlternativeSpellings = new[] { "LB", "Lebanese Republic", "Al-Jumhūrīyah Al-Libnānīyah" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Isr, CountryCodeIso3.Syr },
                    Landlocked = false,
                    Area = 10452,
                };
            }
        }
        public static Country Liberia
        {
            get
            {
                return new Country
                {
                    CommonName = "Liberia",
                    OfficialName = "Republic of Liberia",
                    Tld = new[] { ".lr" },
                    CountryCode = CountryCode.Lr,
                    IsoNumeric = "430",
                    Iso3 = CountryCodeIso3.Lbr,
                    Cioc = "LBR",
                    Currencies = new[] { "LRD" },
                    CallingCodes = new[] { "231" },
                    Capital = "Monrovia",
                    AlternativeSpellings = new[] { "LR", "Republic of Liberia" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Gin, CountryCodeIso3.Civ, CountryCodeIso3.Sle },
                    Landlocked = false,
                    Area = 111369,
                };
            }
        }
        public static Country Libya
        {
            get
            {
                return new Country
                {
                    CommonName = "Libya",
                    OfficialName = "State of Libya",
                    Tld = new[] { ".ly" },
                    CountryCode = CountryCode.Ly,
                    IsoNumeric = "434",
                    Iso3 = CountryCodeIso3.Lby,
                    Cioc = "LBA",
                    Currencies = new[] { "LYD" },
                    CallingCodes = new[] { "218" },
                    Capital = "Tripoli",
                    AlternativeSpellings = new[] { "LY", "State of Libya", "Dawlat Libya" },
                    Region = "Africa",
                    SubRegion = "Northern Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Dza, CountryCodeIso3.Tcd, CountryCodeIso3.Egy, CountryCodeIso3.Ner, CountryCodeIso3.Sdn, CountryCodeIso3.Tun },
                    Landlocked = false,
                    Area = 1759540,
                };
            }
        }
        public static Country SaintLucia
        {
            get
            {
                return new Country
                {
                    CommonName = "Saint Lucia",
                    OfficialName = "Saint Lucia",
                    Tld = new[] { ".lc" },
                    CountryCode = CountryCode.Lc,
                    IsoNumeric = "662",
                    Iso3 = CountryCodeIso3.Lca,
                    Cioc = "LCA",
                    Currencies = new[] { "XCD" },
                    CallingCodes = new[] { "1758" },
                    Capital = "Castries",
                    AlternativeSpellings = new[] { "LC" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 616,
                };
            }
        }
        public static Country Liechtenstein
        {
            get
            {
                return new Country
                {
                    CommonName = "Liechtenstein",
                    OfficialName = "Principality of Liechtenstein",
                    Tld = new[] { ".li" },
                    CountryCode = CountryCode.Li,
                    IsoNumeric = "438",
                    Iso3 = CountryCodeIso3.Lie,
                    Cioc = "LIE",
                    Currencies = new[] { "CHF" },
                    CallingCodes = new[] { "423" },
                    Capital = "Vaduz",
                    AlternativeSpellings = new[] { "LI", "Principality of Liechtenstein", "Fürstentum Liechtenstein" },
                    Region = "Europe",
                    SubRegion = "Western Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Aut, CountryCodeIso3.Che },
                    Landlocked = true,
                    Area = 160,
                };
            }
        }
        public static Country SriLanka
        {
            get
            {
                return new Country
                {
                    CommonName = "Sri Lanka",
                    OfficialName = "Democratic Socialist Republic of Sri Lanka",
                    Tld = new[] { ".lk", ".இலங்கை", ".ලංකා" },
                    CountryCode = CountryCode.Lk,
                    IsoNumeric = "144",
                    Iso3 = CountryCodeIso3.Lka,
                    Cioc = "SRI",
                    Currencies = new[] { "LKR" },
                    CallingCodes = new[] { "94" },
                    Capital = "Colombo",
                    AlternativeSpellings = new[] { "LK", "ilaṅkai", "Democratic Socialist Republic of Sri Lanka" },
                    Region = "Asia",
                    SubRegion = "Southern Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Ind },
                    Landlocked = false,
                    Area = 65610,
                };
            }
        }
        public static Country Lesotho
        {
            get
            {
                return new Country
                {
                    CommonName = "Lesotho",
                    OfficialName = "Kingdom of Lesotho",
                    Tld = new[] { ".ls" },
                    CountryCode = CountryCode.Ls,
                    IsoNumeric = "426",
                    Iso3 = CountryCodeIso3.Lso,
                    Cioc = "LES",
                    Currencies = new[] { "LSL", "ZAR" },
                    CallingCodes = new[] { "266" },
                    Capital = "Maseru",
                    AlternativeSpellings = new[] { "LS", "Kingdom of Lesotho", "Muso oa Lesotho" },
                    Region = "Africa",
                    SubRegion = "Southern Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Zaf },
                    Landlocked = true,
                    Area = 30355,
                };
            }
        }
        public static Country Lithuania
        {
            get
            {
                return new Country
                {
                    CommonName = "Lithuania",
                    OfficialName = "Republic of Lithuania",
                    Tld = new[] { ".lt" },
                    CountryCode = CountryCode.Lt,
                    IsoNumeric = "440",
                    Iso3 = CountryCodeIso3.Ltu,
                    Cioc = "LTU",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "370" },
                    Capital = "Vilnius",
                    AlternativeSpellings = new[] { "LT", "Republic of Lithuania", "Lietuvos Respublika" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Blr, CountryCodeIso3.Lva, CountryCodeIso3.Pol, CountryCodeIso3.Rus },
                    Landlocked = false,
                    Area = 65300,
                };
            }
        }
        public static Country Luxembourg
        {
            get
            {
                return new Country
                {
                    CommonName = "Luxembourg",
                    OfficialName = "Grand Duchy of Luxembourg",
                    Tld = new[] { ".lu" },
                    CountryCode = CountryCode.Lu,
                    IsoNumeric = "442",
                    Iso3 = CountryCodeIso3.Lux,
                    Cioc = "LUX",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "352" },
                    Capital = "Luxembourg",
                    AlternativeSpellings = new[] { "LU", "Grand Duchy of Luxembourg", "Grand-Duché de Luxembourg", "Großherzogtum Luxemburg", "Groussherzogtum Lëtzebuerg" },
                    Region = "Europe",
                    SubRegion = "Western Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Bel, CountryCodeIso3.Fra, CountryCodeIso3.Deu },
                    Landlocked = true,
                    Area = 2586,
                };
            }
        }
        public static Country Latvia
        {
            get
            {
                return new Country
                {
                    CommonName = "Latvia",
                    OfficialName = "Republic of Latvia",
                    Tld = new[] { ".lv" },
                    CountryCode = CountryCode.Lv,
                    IsoNumeric = "428",
                    Iso3 = CountryCodeIso3.Lva,
                    Cioc = "LAT",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "371" },
                    Capital = "Riga",
                    AlternativeSpellings = new[] { "LV", "Republic of Latvia", "Latvijas Republika" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Blr, CountryCodeIso3.Est, CountryCodeIso3.Ltu, CountryCodeIso3.Rus },
                    Landlocked = false,
                    Area = 64559,
                };
            }
        }
        public static Country Macau
        {
            get
            {
                return new Country
                {
                    CommonName = "Macau",
                    OfficialName = "Macao Special Administrative Region of the People's Republic of China",
                    Tld = new[] { ".mo" },
                    CountryCode = CountryCode.Mo,
                    IsoNumeric = "446",
                    Iso3 = CountryCodeIso3.Mac,
                    Cioc = "",
                    Currencies = new[] { "MOP" },
                    CallingCodes = new[] { "853" },
                    Capital = "",
                    AlternativeSpellings = new[] { "MO", "澳门", "Macao", "Macao Special Administrative Region of the People's Republic of China", "中華人民共和國澳門特別行政區", "Região Administrativa Especial de Macau da República Popular da China" },
                    Region = "Asia",
                    SubRegion = "Eastern Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Chn },
                    Landlocked = false,
                    Area = 30,
                };
            }
        }
        public static Country SaintMartin
        {
            get
            {
                return new Country
                {
                    CommonName = "Saint Martin",
                    OfficialName = "Saint Martin",
                    Tld = new[] { ".fr", ".gp" },
                    CountryCode = CountryCode.Mf,
                    IsoNumeric = "663",
                    Iso3 = CountryCodeIso3.Maf,
                    Cioc = "",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "590" },
                    Capital = "Marigot",
                    AlternativeSpellings = new[] { "MF", "Collectivity of Saint Martin", "Collectivité de Saint-Martin", "Saint Martin (French part)" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Sxm },
                    Landlocked = false,
                    Area = 53,
                };
            }
        }
        public static Country Morocco
        {
            get
            {
                return new Country
                {
                    CommonName = "Morocco",
                    OfficialName = "Kingdom of Morocco",
                    Tld = new[] { ".ma", "المغرب." },
                    CountryCode = CountryCode.Ma,
                    IsoNumeric = "504",
                    Iso3 = CountryCodeIso3.Mar,
                    Cioc = "MAR",
                    Currencies = new[] { "MAD" },
                    CallingCodes = new[] { "212" },
                    Capital = "Rabat",
                    AlternativeSpellings = new[] { "MA", "Kingdom of Morocco", "Al-Mamlakah al-Maġribiyah" },
                    Region = "Africa",
                    SubRegion = "Northern Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Dza, CountryCodeIso3.Esh, CountryCodeIso3.Esp },
                    Landlocked = false,
                    Area = 446550,
                };
            }
        }
        public static Country Monaco
        {
            get
            {
                return new Country
                {
                    CommonName = "Monaco",
                    OfficialName = "Principality of Monaco",
                    Tld = new[] { ".mc" },
                    CountryCode = CountryCode.Mc,
                    IsoNumeric = "492",
                    Iso3 = CountryCodeIso3.Mco,
                    Cioc = "MON",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "377" },
                    Capital = "Monaco",
                    AlternativeSpellings = new[] { "MC", "Principality of Monaco", "Principauté de Monaco" },
                    Region = "Europe",
                    SubRegion = "Western Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Fra },
                    Landlocked = false,
                    Area = 2,
                };
            }
        }
        public static Country Moldova
        {
            get
            {
                return new Country
                {
                    CommonName = "Moldova",
                    OfficialName = "Republic of Moldova",
                    Tld = new[] { ".md" },
                    CountryCode = CountryCode.Md,
                    IsoNumeric = "498",
                    Iso3 = CountryCodeIso3.Mda,
                    Cioc = "MDA",
                    Currencies = new[] { "MDL" },
                    CallingCodes = new[] { "373" },
                    Capital = "Chișinău",
                    AlternativeSpellings = new[] { "MD", "Moldova, Republic of", "Republic of Moldova", "Republica Moldova" },
                    Region = "Europe",
                    SubRegion = "Eastern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Rou, CountryCodeIso3.Ukr },
                    Landlocked = true,
                    Area = 33846,
                };
            }
        }
        public static Country Madagascar
        {
            get
            {
                return new Country
                {
                    CommonName = "Madagascar",
                    OfficialName = "Republic of Madagascar",
                    Tld = new[] { ".mg" },
                    CountryCode = CountryCode.Mg,
                    IsoNumeric = "450",
                    Iso3 = CountryCodeIso3.Mdg,
                    Cioc = "MAD",
                    Currencies = new[] { "MGA" },
                    CallingCodes = new[] { "261" },
                    Capital = "Antananarivo",
                    AlternativeSpellings = new[] { "MG", "Republic of Madagascar", "Repoblikan'i Madagasikara", "République de Madagascar" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 587041,
                };
            }
        }
        public static Country Maldives
        {
            get
            {
                return new Country
                {
                    CommonName = "Maldives",
                    OfficialName = "Republic of the Maldives",
                    Tld = new[] { ".mv" },
                    CountryCode = CountryCode.Mv,
                    IsoNumeric = "462",
                    Iso3 = CountryCodeIso3.Mdv,
                    Cioc = "MDV",
                    Currencies = new[] { "MVR" },
                    CallingCodes = new[] { "960" },
                    Capital = "Malé",
                    AlternativeSpellings = new[] { "MV", "Maldive Islands", "Republic of the Maldives", "Dhivehi Raajjeyge Jumhooriyya" },
                    Region = "Asia",
                    SubRegion = "Southern Asia",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 300,
                };
            }
        }
        public static Country Mexico
        {
            get
            {
                return new Country
                {
                    CommonName = "Mexico",
                    OfficialName = "United Mexican States",
                    Tld = new[] { ".mx" },
                    CountryCode = CountryCode.Mx,
                    IsoNumeric = "484",
                    Iso3 = CountryCodeIso3.Mex,
                    Cioc = "MEX",
                    Currencies = new[] { "MXN" },
                    CallingCodes = new[] { "52" },
                    Capital = "Mexico City",
                    AlternativeSpellings = new[] { "MX", "Mexicanos", "United Mexican States", "Estados Unidos Mexicanos" },
                    Region = "Americas",
                    SubRegion = "Central America",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Blz, CountryCodeIso3.Gtm, CountryCodeIso3.Usa },
                    Landlocked = false,
                    Area = 1964375,
                };
            }
        }
        public static Country MarshallIslands
        {
            get
            {
                return new Country
                {
                    CommonName = "Marshall Islands",
                    OfficialName = "Republic of the Marshall Islands",
                    Tld = new[] { ".mh" },
                    CountryCode = CountryCode.Mh,
                    IsoNumeric = "584",
                    Iso3 = CountryCodeIso3.Mhl,
                    Cioc = "MHL",
                    Currencies = new[] { "USD" },
                    CallingCodes = new[] { "692" },
                    Capital = "Majuro",
                    AlternativeSpellings = new[] { "MH", "Republic of the Marshall Islands", "Aolepān Aorōkin M̧ajeļ" },
                    Region = "Oceania",
                    SubRegion = "Micronesia",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 181,
                };
            }
        }
        public static Country Macedonia
        {
            get
            {
                return new Country
                {
                    CommonName = "Macedonia",
                    OfficialName = "Republic of Macedonia",
                    Tld = new[] { ".mk" },
                    CountryCode = CountryCode.Mk,
                    IsoNumeric = "807",
                    Iso3 = CountryCodeIso3.Mkd,
                    Cioc = "MKD",
                    Currencies = new[] { "MKD" },
                    CallingCodes = new[] { "389" },
                    Capital = "Skopje",
                    AlternativeSpellings = new[] { "MK", "Macedonia, the Former Yugoslav Republic of", "Republic of Macedonia", "Република Македонија" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Alb, CountryCodeIso3.Bgr, CountryCodeIso3.Grc, CountryCodeIso3.Kos, CountryCodeIso3.Srb },
                    Landlocked = true,
                    Area = 25713,
                };
            }
        }
        public static Country Mali
        {
            get
            {
                return new Country
                {
                    CommonName = "Mali",
                    OfficialName = "Republic of Mali",
                    Tld = new[] { ".ml" },
                    CountryCode = CountryCode.Ml,
                    IsoNumeric = "466",
                    Iso3 = CountryCodeIso3.Mli,
                    Cioc = "MLI",
                    Currencies = new[] { "XOF" },
                    CallingCodes = new[] { "223" },
                    Capital = "Bamako",
                    AlternativeSpellings = new[] { "ML", "Republic of Mali", "République du Mali" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Dza, CountryCodeIso3.Bfa, CountryCodeIso3.Gin, CountryCodeIso3.Civ, CountryCodeIso3.Mrt, CountryCodeIso3.Ner, CountryCodeIso3.Sen },
                    Landlocked = true,
                    Area = 1240192,
                };
            }
        }
        public static Country Malta
        {
            get
            {
                return new Country
                {
                    CommonName = "Malta",
                    OfficialName = "Republic of Malta",
                    Tld = new[] { ".mt" },
                    CountryCode = CountryCode.Mt,
                    IsoNumeric = "470",
                    Iso3 = CountryCodeIso3.Mlt,
                    Cioc = "MLT",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "356" },
                    Capital = "Valletta",
                    AlternativeSpellings = new[] { "MT", "Republic of Malta", "Repubblika ta' Malta" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 316,
                };
            }
        }
        public static Country Myanmar
        {
            get
            {
                return new Country
                {
                    CommonName = "Myanmar",
                    OfficialName = "Republic of the Union of Myanmar",
                    Tld = new[] { ".mm" },
                    CountryCode = CountryCode.Mm,
                    IsoNumeric = "104",
                    Iso3 = CountryCodeIso3.Mmr,
                    Cioc = "MYA",
                    Currencies = new[] { "MMK" },
                    CallingCodes = new[] { "95" },
                    Capital = "Naypyidaw",
                    AlternativeSpellings = new[] { "MM", "Burma", "Republic of the Union of Myanmar", "Pyidaunzu Thanmăda Myăma Nainngandaw" },
                    Region = "Asia",
                    SubRegion = "South-Eastern Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Bgd, CountryCodeIso3.Chn, CountryCodeIso3.Ind, CountryCodeIso3.Lao, CountryCodeIso3.Tha },
                    Landlocked = false,
                    Area = 676578,
                };
            }
        }
        public static Country Montenegro
        {
            get
            {
                return new Country
                {
                    CommonName = "Montenegro",
                    OfficialName = "Montenegro",
                    Tld = new[] { ".me" },
                    CountryCode = CountryCode.Me,
                    IsoNumeric = "499",
                    Iso3 = CountryCodeIso3.Mne,
                    Cioc = "MNE",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "382" },
                    Capital = "Podgorica",
                    AlternativeSpellings = new[] { "ME", "Crna Gora" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Alb, CountryCodeIso3.Bih, CountryCodeIso3.Hrv, CountryCodeIso3.Kos, CountryCodeIso3.Srb },
                    Landlocked = false,
                    Area = 13812,
                };
            }
        }
        public static Country Mongolia
        {
            get
            {
                return new Country
                {
                    CommonName = "Mongolia",
                    OfficialName = "Mongolia",
                    Tld = new[] { ".mn" },
                    CountryCode = CountryCode.Mn,
                    IsoNumeric = "496",
                    Iso3 = CountryCodeIso3.Mng,
                    Cioc = "MGL",
                    Currencies = new[] { "MNT" },
                    CallingCodes = new[] { "976" },
                    Capital = "Ulan Bator",
                    AlternativeSpellings = new[] { "MN" },
                    Region = "Asia",
                    SubRegion = "Eastern Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Chn, CountryCodeIso3.Rus },
                    Landlocked = true,
                    Area = 1564110,
                };
            }
        }
        public static Country NorthernMarianaIslands
        {
            get
            {
                return new Country
                {
                    CommonName = "Northern Mariana Islands",
                    OfficialName = "Commonwealth of the Northern Mariana Islands",
                    Tld = new[] { ".mp" },
                    CountryCode = CountryCode.Mp,
                    IsoNumeric = "580",
                    Iso3 = CountryCodeIso3.Mnp,
                    Cioc = "",
                    Currencies = new[] { "USD" },
                    CallingCodes = new[] { "1670" },
                    Capital = "Saipan",
                    AlternativeSpellings = new[] { "MP", "Commonwealth of the Northern Mariana Islands", "Sankattan Siha Na Islas Mariånas" },
                    Region = "Oceania",
                    SubRegion = "Micronesia",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 464,
                };
            }
        }
        public static Country Mozambique
        {
            get
            {
                return new Country
                {
                    CommonName = "Mozambique",
                    OfficialName = "Republic of Mozambique",
                    Tld = new[] { ".mz" },
                    CountryCode = CountryCode.Mz,
                    IsoNumeric = "508",
                    Iso3 = CountryCodeIso3.Moz,
                    Cioc = "MOZ",
                    Currencies = new[] { "MZN" },
                    CallingCodes = new[] { "258" },
                    Capital = "Maputo",
                    AlternativeSpellings = new[] { "MZ", "Republic of Mozambique", "República de Moçambique" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Mwi, CountryCodeIso3.Zaf, CountryCodeIso3.Swz, CountryCodeIso3.Tza, CountryCodeIso3.Zmb, CountryCodeIso3.Zwe },
                    Landlocked = false,
                    Area = 801590,
                };
            }
        }
        public static Country Mauritania
        {
            get
            {
                return new Country
                {
                    CommonName = "Mauritania",
                    OfficialName = "Islamic Republic of Mauritania",
                    Tld = new[] { ".mr" },
                    CountryCode = CountryCode.Mr,
                    IsoNumeric = "478",
                    Iso3 = CountryCodeIso3.Mrt,
                    Cioc = "MTN",
                    Currencies = new[] { "MRO" },
                    CallingCodes = new[] { "222" },
                    Capital = "Nouakchott",
                    AlternativeSpellings = new[] { "MR", "Islamic Republic of Mauritania", "al-Jumhūriyyah al-ʾIslāmiyyah al-Mūrītāniyyah" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Dza, CountryCodeIso3.Mli, CountryCodeIso3.Sen, CountryCodeIso3.Esh },
                    Landlocked = false,
                    Area = 1030700,
                };
            }
        }
        public static Country Montserrat
        {
            get
            {
                return new Country
                {
                    CommonName = "Montserrat",
                    OfficialName = "Montserrat",
                    Tld = new[] { ".ms" },
                    CountryCode = CountryCode.Ms,
                    IsoNumeric = "500",
                    Iso3 = CountryCodeIso3.Msr,
                    Cioc = "",
                    Currencies = new[] { "XCD" },
                    CallingCodes = new[] { "1664" },
                    Capital = "Plymouth",
                    AlternativeSpellings = new[] { "MS" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 102,
                };
            }
        }
        public static Country Martinique
        {
            get
            {
                return new Country
                {
                    CommonName = "Martinique",
                    OfficialName = "Martinique",
                    Tld = new[] { ".mq" },
                    CountryCode = CountryCode.Mq,
                    IsoNumeric = "474",
                    Iso3 = CountryCodeIso3.Mtq,
                    Cioc = "",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "596" },
                    Capital = "Fort-de-France",
                    AlternativeSpellings = new[] { "MQ" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 1128,
                };
            }
        }
        public static Country Mauritius
        {
            get
            {
                return new Country
                {
                    CommonName = "Mauritius",
                    OfficialName = "Republic of Mauritius",
                    Tld = new[] { ".mu" },
                    CountryCode = CountryCode.Mu,
                    IsoNumeric = "480",
                    Iso3 = CountryCodeIso3.Mus,
                    Cioc = "MRI",
                    Currencies = new[] { "MUR" },
                    CallingCodes = new[] { "230" },
                    Capital = "Port Louis",
                    AlternativeSpellings = new[] { "MU", "Republic of Mauritius", "République de Maurice" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 2040,
                };
            }
        }
        public static Country Malawi
        {
            get
            {
                return new Country
                {
                    CommonName = "Malawi",
                    OfficialName = "Republic of Malawi",
                    Tld = new[] { ".mw" },
                    CountryCode = CountryCode.Mw,
                    IsoNumeric = "454",
                    Iso3 = CountryCodeIso3.Mwi,
                    Cioc = "MAW",
                    Currencies = new[] { "MWK" },
                    CallingCodes = new[] { "265" },
                    Capital = "Lilongwe",
                    AlternativeSpellings = new[] { "MW", "Republic of Malawi" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Moz, CountryCodeIso3.Tza, CountryCodeIso3.Zmb },
                    Landlocked = true,
                    Area = 118484,
                };
            }
        }
        public static Country Malaysia
        {
            get
            {
                return new Country
                {
                    CommonName = "Malaysia",
                    OfficialName = "Malaysia",
                    Tld = new[] { ".my" },
                    CountryCode = CountryCode.My,
                    IsoNumeric = "458",
                    Iso3 = CountryCodeIso3.Mys,
                    Cioc = "MAS",
                    Currencies = new[] { "MYR" },
                    CallingCodes = new[] { "60" },
                    Capital = "Kuala Lumpur",
                    AlternativeSpellings = new[] { "MY" },
                    Region = "Asia",
                    SubRegion = "South-Eastern Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Brn, CountryCodeIso3.Idn, CountryCodeIso3.Tha },
                    Landlocked = false,
                    Area = 330803,
                };
            }
        }
        public static Country Mayotte
        {
            get
            {
                return new Country
                {
                    CommonName = "Mayotte",
                    OfficialName = "Department of Mayotte",
                    Tld = new[] { ".yt" },
                    CountryCode = CountryCode.Yt,
                    IsoNumeric = "175",
                    Iso3 = CountryCodeIso3.Myt,
                    Cioc = "",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "262" },
                    Capital = "Mamoudzou",
                    AlternativeSpellings = new[] { "YT", "Department of Mayotte", "Département de Mayotte" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 374,
                };
            }
        }
        public static Country Namibia
        {
            get
            {
                return new Country
                {
                    CommonName = "Namibia",
                    OfficialName = "Republic of Namibia",
                    Tld = new[] { ".na" },
                    CountryCode = CountryCode.Na,
                    IsoNumeric = "516",
                    Iso3 = CountryCodeIso3.Nam,
                    Cioc = "NAM",
                    Currencies = new[] { "NAD", "ZAR" },
                    CallingCodes = new[] { "264" },
                    Capital = "Windhoek",
                    AlternativeSpellings = new[] { "NA", "Namibië", "Republic of Namibia" },
                    Region = "Africa",
                    SubRegion = "Southern Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Ago, CountryCodeIso3.Bwa, CountryCodeIso3.Zaf, CountryCodeIso3.Zmb },
                    Landlocked = false,
                    Area = 825615,
                };
            }
        }
        public static Country NewCaledonia
        {
            get
            {
                return new Country
                {
                    CommonName = "New Caledonia",
                    OfficialName = "New Caledonia",
                    Tld = new[] { ".nc" },
                    CountryCode = CountryCode.Nc,
                    IsoNumeric = "540",
                    Iso3 = CountryCodeIso3.Ncl,
                    Cioc = "",
                    Currencies = new[] { "XPF" },
                    CallingCodes = new[] { "687" },
                    Capital = "Nouméa",
                    AlternativeSpellings = new[] { "NC" },
                    Region = "Oceania",
                    SubRegion = "Melanesia",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 18575,
                };
            }
        }
        public static Country Niger
        {
            get
            {
                return new Country
                {
                    CommonName = "Niger",
                    OfficialName = "Republic of Niger",
                    Tld = new[] { ".ne" },
                    CountryCode = CountryCode.Ne,
                    IsoNumeric = "562",
                    Iso3 = CountryCodeIso3.Ner,
                    Cioc = "NIG",
                    Currencies = new[] { "XOF" },
                    CallingCodes = new[] { "227" },
                    Capital = "Niamey",
                    AlternativeSpellings = new[] { "NE", "Nijar" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Dza, CountryCodeIso3.Ben, CountryCodeIso3.Bfa, CountryCodeIso3.Tcd, CountryCodeIso3.Lby, CountryCodeIso3.Mli, CountryCodeIso3.Nga },
                    Landlocked = true,
                    Area = 1267000,
                };
            }
        }
        public static Country NorfolkIsland
        {
            get
            {
                return new Country
                {
                    CommonName = "Norfolk Island",
                    OfficialName = "Territory of Norfolk Island",
                    Tld = new[] { ".nf" },
                    CountryCode = CountryCode.Nf,
                    IsoNumeric = "574",
                    Iso3 = CountryCodeIso3.Nfk,
                    Cioc = "",
                    Currencies = new[] { "AUD" },
                    CallingCodes = new[] { "672" },
                    Capital = "Kingston",
                    AlternativeSpellings = new[] { "NF", "Territory of Norfolk Island", "Teratri of Norf'k Ailen" },
                    Region = "Oceania",
                    SubRegion = "Australia and New Zealand",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 36,
                };
            }
        }
        public static Country Nigeria
        {
            get
            {
                return new Country
                {
                    CommonName = "Nigeria",
                    OfficialName = "Federal Republic of Nigeria",
                    Tld = new[] { ".ng" },
                    CountryCode = CountryCode.Ng,
                    IsoNumeric = "566",
                    Iso3 = CountryCodeIso3.Nga,
                    Cioc = "NGR",
                    Currencies = new[] { "NGN" },
                    CallingCodes = new[] { "234" },
                    Capital = "Abuja",
                    AlternativeSpellings = new[] { "NG", "Nijeriya", "Naíjíríà", "Federal Republic of Nigeria" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Ben, CountryCodeIso3.Cmr, CountryCodeIso3.Tcd, CountryCodeIso3.Ner },
                    Landlocked = false,
                    Area = 923768,
                };
            }
        }
        public static Country Nicaragua
        {
            get
            {
                return new Country
                {
                    CommonName = "Nicaragua",
                    OfficialName = "Republic of Nicaragua",
                    Tld = new[] { ".ni" },
                    CountryCode = CountryCode.Ni,
                    IsoNumeric = "558",
                    Iso3 = CountryCodeIso3.Nic,
                    Cioc = "NCA",
                    Currencies = new[] { "NIO" },
                    CallingCodes = new[] { "505" },
                    Capital = "Managua",
                    AlternativeSpellings = new[] { "NI", "Republic of Nicaragua", "República de Nicaragua" },
                    Region = "Americas",
                    SubRegion = "Central America",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Cri, CountryCodeIso3.Hnd },
                    Landlocked = false,
                    Area = 130373,
                };
            }
        }
        public static Country Niue
        {
            get
            {
                return new Country
                {
                    CommonName = "Niue",
                    OfficialName = "Niue",
                    Tld = new[] { ".nu" },
                    CountryCode = CountryCode.Nu,
                    IsoNumeric = "570",
                    Iso3 = CountryCodeIso3.Niu,
                    Cioc = "",
                    Currencies = new[] { "NZD" },
                    CallingCodes = new[] { "683" },
                    Capital = "Alofi",
                    AlternativeSpellings = new[] { "NU" },
                    Region = "Oceania",
                    SubRegion = "Polynesia",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 260,
                };
            }
        }
        public static Country Netherlands
        {
            get
            {
                return new Country
                {
                    CommonName = "Netherlands",
                    OfficialName = "Netherlands",
                    Tld = new[] { ".nl" },
                    CountryCode = CountryCode.Nl,
                    IsoNumeric = "528",
                    Iso3 = CountryCodeIso3.Nld,
                    Cioc = "NED",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "31" },
                    Capital = "Amsterdam",
                    AlternativeSpellings = new[] { "NL", "Holland", "Nederland" },
                    Region = "Europe",
                    SubRegion = "Western Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Bel, CountryCodeIso3.Deu },
                    Landlocked = false,
                    Area = 41850,
                };
            }
        }
        public static Country Norway
        {
            get
            {
                return new Country
                {
                    CommonName = "Norway",
                    OfficialName = "Kingdom of Norway",
                    Tld = new[] { ".no" },
                    CountryCode = CountryCode.No,
                    IsoNumeric = "578",
                    Iso3 = CountryCodeIso3.Nor,
                    Cioc = "NOR",
                    Currencies = new[] { "NOK" },
                    CallingCodes = new[] { "47" },
                    Capital = "Oslo",
                    AlternativeSpellings = new[] { "NO", "Norge", "Noreg", "Kingdom of Norway", "Kongeriket Norge", "Kongeriket Noreg" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Fin, CountryCodeIso3.Swe, CountryCodeIso3.Rus },
                    Landlocked = false,
                    Area = 323802,
                };
            }
        }
        public static Country Nepal
        {
            get
            {
                return new Country
                {
                    CommonName = "Nepal",
                    OfficialName = "Federal Democratic Republic of Nepal",
                    Tld = new[] { ".np" },
                    CountryCode = CountryCode.Np,
                    IsoNumeric = "524",
                    Iso3 = CountryCodeIso3.Npl,
                    Cioc = "NEP",
                    Currencies = new[] { "NPR" },
                    CallingCodes = new[] { "977" },
                    Capital = "Kathmandu",
                    AlternativeSpellings = new[] { "NP", "Federal Democratic Republic of Nepal", "Loktāntrik Ganatantra Nepāl" },
                    Region = "Asia",
                    SubRegion = "Southern Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Chn, CountryCodeIso3.Ind },
                    Landlocked = true,
                    Area = 147181,
                };
            }
        }
        public static Country Nauru
        {
            get
            {
                return new Country
                {
                    CommonName = "Nauru",
                    OfficialName = "Republic of Nauru",
                    Tld = new[] { ".nr" },
                    CountryCode = CountryCode.Nr,
                    IsoNumeric = "520",
                    Iso3 = CountryCodeIso3.Nru,
                    Cioc = "NRU",
                    Currencies = new[] { "AUD" },
                    CallingCodes = new[] { "674" },
                    Capital = "Yaren",
                    AlternativeSpellings = new[] { "NR", "Naoero", "Pleasant Island", "Republic of Nauru", "Ripublik Naoero" },
                    Region = "Oceania",
                    SubRegion = "Micronesia",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 21,
                };
            }
        }
        public static Country NewZealand
        {
            get
            {
                return new Country
                {
                    CommonName = "New Zealand",
                    OfficialName = "New Zealand",
                    Tld = new[] { ".nz" },
                    CountryCode = CountryCode.Nz,
                    IsoNumeric = "554",
                    Iso3 = CountryCodeIso3.Nzl,
                    Cioc = "NZL",
                    Currencies = new[] { "NZD" },
                    CallingCodes = new[] { "64" },
                    Capital = "Wellington",
                    AlternativeSpellings = new[] { "NZ", "Aotearoa" },
                    Region = "Oceania",
                    SubRegion = "Australia and New Zealand",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 270467,
                };
            }
        }
        public static Country Oman
        {
            get
            {
                return new Country
                {
                    CommonName = "Oman",
                    OfficialName = "Sultanate of Oman",
                    Tld = new[] { ".om" },
                    CountryCode = CountryCode.Om,
                    IsoNumeric = "512",
                    Iso3 = CountryCodeIso3.Omn,
                    Cioc = "OMA",
                    Currencies = new[] { "OMR" },
                    CallingCodes = new[] { "968" },
                    Capital = "Muscat",
                    AlternativeSpellings = new[] { "OM", "Sultanate of Oman", "Salṭanat ʻUmān" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Sau, CountryCodeIso3.Are, CountryCodeIso3.Yem },
                    Landlocked = false,
                    Area = 309500,
                };
            }
        }
        public static Country Pakistan
        {
            get
            {
                return new Country
                {
                    CommonName = "Pakistan",
                    OfficialName = "Islamic Republic of Pakistan",
                    Tld = new[] { ".pk" },
                    CountryCode = CountryCode.Pk,
                    IsoNumeric = "586",
                    Iso3 = CountryCodeIso3.Pak,
                    Cioc = "PAK",
                    Currencies = new[] { "PKR" },
                    CallingCodes = new[] { "92" },
                    Capital = "Islamabad",
                    AlternativeSpellings = new[] { "PK", "Pākistān", "Islamic Republic of Pakistan", "Islāmī Jumhūriya'eh Pākistān" },
                    Region = "Asia",
                    SubRegion = "Southern Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Afg, CountryCodeIso3.Chn, CountryCodeIso3.Ind, CountryCodeIso3.Irn },
                    Landlocked = false,
                    Area = 881912,
                };
            }
        }
        public static Country Panama
        {
            get
            {
                return new Country
                {
                    CommonName = "Panama",
                    OfficialName = "Republic of Panama",
                    Tld = new[] { ".pa" },
                    CountryCode = CountryCode.Pa,
                    IsoNumeric = "591",
                    Iso3 = CountryCodeIso3.Pan,
                    Cioc = "PAN",
                    Currencies = new[] { "PAB", "USD" },
                    CallingCodes = new[] { "507" },
                    Capital = "Panama City",
                    AlternativeSpellings = new[] { "PA", "Republic of Panama", "República de Panamá" },
                    Region = "Americas",
                    SubRegion = "Central America",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Col, CountryCodeIso3.Cri },
                    Landlocked = false,
                    Area = 75417,
                };
            }
        }
        public static Country PitcairnIslands
        {
            get
            {
                return new Country
                {
                    CommonName = "Pitcairn Islands",
                    OfficialName = "Pitcairn Group of Islands",
                    Tld = new[] { ".pn" },
                    CountryCode = CountryCode.Pn,
                    IsoNumeric = "612",
                    Iso3 = CountryCodeIso3.Pcn,
                    Cioc = "",
                    Currencies = new[] { "NZD" },
                    CallingCodes = new[] { "64" },
                    Capital = "Adamstown",
                    AlternativeSpellings = new[] { "PN", "Pitcairn", "Pitcairn Henderson Ducie and Oeno Islands" },
                    Region = "Oceania",
                    SubRegion = "Polynesia",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 47,
                };
            }
        }
        public static Country Peru
        {
            get
            {
                return new Country
                {
                    CommonName = "Peru",
                    OfficialName = "Republic of Peru",
                    Tld = new[] { ".pe" },
                    CountryCode = CountryCode.Pe,
                    IsoNumeric = "604",
                    Iso3 = CountryCodeIso3.Per,
                    Cioc = "PER",
                    Currencies = new[] { "PEN" },
                    CallingCodes = new[] { "51" },
                    Capital = "Lima",
                    AlternativeSpellings = new[] { "PE", "Republic of Peru", "República del Perú" },
                    Region = "Americas",
                    SubRegion = "South America",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Bol, CountryCodeIso3.Bra, CountryCodeIso3.Chl, CountryCodeIso3.Col, CountryCodeIso3.Ecu },
                    Landlocked = false,
                    Area = 1285216,
                };
            }
        }
        public static Country Philippines
        {
            get
            {
                return new Country
                {
                    CommonName = "Philippines",
                    OfficialName = "Republic of the Philippines",
                    Tld = new[] { ".ph" },
                    CountryCode = CountryCode.Ph,
                    IsoNumeric = "608",
                    Iso3 = CountryCodeIso3.Phl,
                    Cioc = "PHI",
                    Currencies = new[] { "PHP" },
                    CallingCodes = new[] { "63" },
                    Capital = "Manila",
                    AlternativeSpellings = new[] { "PH", "Republic of the Philippines", "Repúblika ng Pilipinas" },
                    Region = "Asia",
                    SubRegion = "South-Eastern Asia",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 342353,
                };
            }
        }
        public static Country Palau
        {
            get
            {
                return new Country
                {
                    CommonName = "Palau",
                    OfficialName = "Republic of Palau",
                    Tld = new[] { ".pw" },
                    CountryCode = CountryCode.Pw,
                    IsoNumeric = "585",
                    Iso3 = CountryCodeIso3.Plw,
                    Cioc = "PLW",
                    Currencies = new[] { "USD" },
                    CallingCodes = new[] { "680" },
                    Capital = "Ngerulmud",
                    AlternativeSpellings = new[] { "PW", "Republic of Palau", "Beluu er a Belau" },
                    Region = "Oceania",
                    SubRegion = "Micronesia",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 459,
                };
            }
        }
        public static Country PapuaNewGuinea
        {
            get
            {
                return new Country
                {
                    CommonName = "Papua New Guinea",
                    OfficialName = "Independent State of Papua New Guinea",
                    Tld = new[] { ".pg" },
                    CountryCode = CountryCode.Pg,
                    IsoNumeric = "598",
                    Iso3 = CountryCodeIso3.Png,
                    Cioc = "PNG",
                    Currencies = new[] { "PGK" },
                    CallingCodes = new[] { "675" },
                    Capital = "Port Moresby",
                    AlternativeSpellings = new[] { "PG", "Independent State of Papua New Guinea", "Independen Stet bilong Papua Niugini" },
                    Region = "Oceania",
                    SubRegion = "Melanesia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Idn },
                    Landlocked = false,
                    Area = 462840,
                };
            }
        }
        public static Country Poland
        {
            get
            {
                return new Country
                {
                    CommonName = "Poland",
                    OfficialName = "Republic of Poland",
                    Tld = new[] { ".pl" },
                    CountryCode = CountryCode.Pl,
                    IsoNumeric = "616",
                    Iso3 = CountryCodeIso3.Pol,
                    Cioc = "POL",
                    Currencies = new[] { "PLN" },
                    CallingCodes = new[] { "48" },
                    Capital = "Warsaw",
                    AlternativeSpellings = new[] { "PL", "Republic of Poland", "Rzeczpospolita Polska" },
                    Region = "Europe",
                    SubRegion = "Eastern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Blr, CountryCodeIso3.Cze, CountryCodeIso3.Deu, CountryCodeIso3.Ltu, CountryCodeIso3.Rus, CountryCodeIso3.Svk, CountryCodeIso3.Ukr },
                    Landlocked = false,
                    Area = 312679,
                };
            }
        }
        public static Country PuertoRico
        {
            get
            {
                return new Country
                {
                    CommonName = "Puerto Rico",
                    OfficialName = "Commonwealth of Puerto Rico",
                    Tld = new[] { ".pr" },
                    CountryCode = CountryCode.Pr,
                    IsoNumeric = "630",
                    Iso3 = CountryCodeIso3.Pri,
                    Cioc = "PUR",
                    Currencies = new[] { "USD" },
                    CallingCodes = new[] { "1787", "1939" },
                    Capital = "San Juan",
                    AlternativeSpellings = new[] { "PR", "Commonwealth of Puerto Rico", "Estado Libre Asociado de Puerto Rico" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 8870,
                };
            }
        }
        public static Country NorthKorea
        {
            get
            {
                return new Country
                {
                    CommonName = "North Korea",
                    OfficialName = "Democratic People's Republic of Korea",
                    Tld = new[] { ".kp" },
                    CountryCode = CountryCode.Kp,
                    IsoNumeric = "408",
                    Iso3 = CountryCodeIso3.Prk,
                    Cioc = "PRK",
                    Currencies = new[] { "KPW" },
                    CallingCodes = new[] { "850" },
                    Capital = "Pyongyang",
                    AlternativeSpellings = new[] { "KP", "Democratic People's Republic of Korea", "조선민주주의인민공화국", "Chosŏn Minjujuŭi Inmin Konghwaguk", "Korea, Democratic People's Republic of" },
                    Region = "Asia",
                    SubRegion = "Eastern Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Chn, CountryCodeIso3.Kor, CountryCodeIso3.Rus },
                    Landlocked = false,
                    Area = 120538,
                };
            }
        }
        public static Country Portugal
        {
            get
            {
                return new Country
                {
                    CommonName = "Portugal",
                    OfficialName = "Portuguese Republic",
                    Tld = new[] { ".pt" },
                    CountryCode = CountryCode.Pt,
                    IsoNumeric = "620",
                    Iso3 = CountryCodeIso3.Prt,
                    Cioc = "POR",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "351" },
                    Capital = "Lisbon",
                    AlternativeSpellings = new[] { "PT", "Portuguesa", "Portuguese Republic", "República Portuguesa" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Esp },
                    Landlocked = false,
                    Area = 92090,
                };
            }
        }
        public static Country Paraguay
        {
            get
            {
                return new Country
                {
                    CommonName = "Paraguay",
                    OfficialName = "Republic of Paraguay",
                    Tld = new[] { ".py" },
                    CountryCode = CountryCode.Py,
                    IsoNumeric = "600",
                    Iso3 = CountryCodeIso3.Pry,
                    Cioc = "PAR",
                    Currencies = new[] { "PYG" },
                    CallingCodes = new[] { "595" },
                    Capital = "Asunción",
                    AlternativeSpellings = new[] { "PY", "Republic of Paraguay", "República del Paraguay", "Tetã Paraguái" },
                    Region = "Americas",
                    SubRegion = "South America",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Arg, CountryCodeIso3.Bol, CountryCodeIso3.Bra },
                    Landlocked = true,
                    Area = 406752,
                };
            }
        }
        public static Country Palestine
        {
            get
            {
                return new Country
                {
                    CommonName = "Palestine",
                    OfficialName = "State of Palestine",
                    Tld = new[] { ".ps", "فلسطين." },
                    CountryCode = CountryCode.Ps,
                    IsoNumeric = "275",
                    Iso3 = CountryCodeIso3.Pse,
                    Cioc = "PLE",
                    Currencies = new[] { "ILS" },
                    CallingCodes = new[] { "970" },
                    Capital = "Ramallah",
                    AlternativeSpellings = new[] { "PS", "Palestine, State of", "State of Palestine", "Dawlat Filasṭin" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Isr, CountryCodeIso3.Egy, CountryCodeIso3.Jor },
                    Landlocked = false,
                    Area = 6220,
                };
            }
        }
        public static Country FrenchPolynesia
        {
            get
            {
                return new Country
                {
                    CommonName = "French Polynesia",
                    OfficialName = "French Polynesia",
                    Tld = new[] { ".pf" },
                    CountryCode = CountryCode.Pf,
                    IsoNumeric = "258",
                    Iso3 = CountryCodeIso3.Pyf,
                    Cioc = "",
                    Currencies = new[] { "XPF" },
                    CallingCodes = new[] { "689" },
                    Capital = "Papeetē",
                    AlternativeSpellings = new[] { "PF", "Polynésie française", "French Polynesia", "Pōrīnetia Farāni" },
                    Region = "Oceania",
                    SubRegion = "Polynesia",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 4167,
                };
            }
        }
        public static Country Qatar
        {
            get
            {
                return new Country
                {
                    CommonName = "Qatar",
                    OfficialName = "State of Qatar",
                    Tld = new[] { ".qa", "قطر." },
                    CountryCode = CountryCode.Qa,
                    IsoNumeric = "634",
                    Iso3 = CountryCodeIso3.Qat,
                    Cioc = "QAT",
                    Currencies = new[] { "QAR" },
                    CallingCodes = new[] { "974" },
                    Capital = "Doha",
                    AlternativeSpellings = new[] { "QA", "State of Qatar", "Dawlat Qaṭar" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Sau },
                    Landlocked = false,
                    Area = 11586,
                };
            }
        }
        public static Country Réunion
        {
            get
            {
                return new Country
                {
                    CommonName = "Réunion",
                    OfficialName = "Réunion Island",
                    Tld = new[] { ".re" },
                    CountryCode = CountryCode.Re,
                    IsoNumeric = "638",
                    Iso3 = CountryCodeIso3.Reu,
                    Cioc = "",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "262" },
                    Capital = "Saint-Denis",
                    AlternativeSpellings = new[] { "RE", "Reunion" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 2511,
                };
            }
        }
        public static Country Romania
        {
            get
            {
                return new Country
                {
                    CommonName = "Romania",
                    OfficialName = "Romania",
                    Tld = new[] { ".ro" },
                    CountryCode = CountryCode.Ro,
                    IsoNumeric = "642",
                    Iso3 = CountryCodeIso3.Rou,
                    Cioc = "ROU",
                    Currencies = new[] { "RON" },
                    CallingCodes = new[] { "40" },
                    Capital = "Bucharest",
                    AlternativeSpellings = new[] { "RO", "Rumania", "Roumania", "România" },
                    Region = "Europe",
                    SubRegion = "Eastern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Bgr, CountryCodeIso3.Hun, CountryCodeIso3.Mda, CountryCodeIso3.Srb, CountryCodeIso3.Ukr },
                    Landlocked = false,
                    Area = 238391,
                };
            }
        }
        public static Country Russia
        {
            get
            {
                return new Country
                {
                    CommonName = "Russia",
                    OfficialName = "Russian Federation",
                    Tld = new[] { ".ru", ".su", ".рф" },
                    CountryCode = CountryCode.Ru,
                    IsoNumeric = "643",
                    Iso3 = CountryCodeIso3.Rus,
                    Cioc = "RUS",
                    Currencies = new[] { "RUB" },
                    CallingCodes = new[] { "7" },
                    Capital = "Moscow",
                    AlternativeSpellings = new[] { "RU", "Rossiya", "Russian Federation", "Российская Федерация", "Rossiyskaya Federatsiya" },
                    Region = "Europe",
                    SubRegion = "Eastern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Aze, CountryCodeIso3.Blr, CountryCodeIso3.Chn, CountryCodeIso3.Est, CountryCodeIso3.Fin, CountryCodeIso3.Geo, CountryCodeIso3.Kaz, CountryCodeIso3.Prk, CountryCodeIso3.Lva, CountryCodeIso3.Ltu, CountryCodeIso3.Mng, CountryCodeIso3.Nor, CountryCodeIso3.Pol, CountryCodeIso3.Ukr },
                    Landlocked = false,
                    Area = 17098242,
                };
            }
        }
        public static Country Rwanda
        {
            get
            {
                return new Country
                {
                    CommonName = "Rwanda",
                    OfficialName = "Republic of Rwanda",
                    Tld = new[] { ".rw" },
                    CountryCode = CountryCode.Rw,
                    IsoNumeric = "646",
                    Iso3 = CountryCodeIso3.Rwa,
                    Cioc = "RWA",
                    Currencies = new[] { "RWF" },
                    CallingCodes = new[] { "250" },
                    Capital = "Kigali",
                    AlternativeSpellings = new[] { "RW", "Republic of Rwanda", "Repubulika y'u Rwanda", "République du Rwanda" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Bdi, CountryCodeIso3.Cod, CountryCodeIso3.Tza, CountryCodeIso3.Uga },
                    Landlocked = true,
                    Area = 26338,
                };
            }
        }
        public static Country SaudiArabia
        {
            get
            {
                return new Country
                {
                    CommonName = "Saudi Arabia",
                    OfficialName = "Kingdom of Saudi Arabia",
                    Tld = new[] { ".sa", ".السعودية" },
                    CountryCode = CountryCode.Sa,
                    IsoNumeric = "682",
                    Iso3 = CountryCodeIso3.Sau,
                    Cioc = "KSA",
                    Currencies = new[] { "SAR" },
                    CallingCodes = new[] { "966" },
                    Capital = "Riyadh",
                    AlternativeSpellings = new[] { "Saudi", "SA", "Kingdom of Saudi Arabia", "Al-Mamlakah al-‘Arabiyyah as-Su‘ūdiyyah" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Irq, CountryCodeIso3.Jor, CountryCodeIso3.Kwt, CountryCodeIso3.Omn, CountryCodeIso3.Qat, CountryCodeIso3.Are, CountryCodeIso3.Yem },
                    Landlocked = false,
                    Area = 2149690,
                };
            }
        }
        public static Country Sudan
        {
            get
            {
                return new Country
                {
                    CommonName = "Sudan",
                    OfficialName = "Republic of the Sudan",
                    Tld = new[] { ".sd" },
                    CountryCode = CountryCode.Sd,
                    IsoNumeric = "729",
                    Iso3 = CountryCodeIso3.Sdn,
                    Cioc = "SUD",
                    Currencies = new[] { "SDG" },
                    CallingCodes = new[] { "249" },
                    Capital = "Khartoum",
                    AlternativeSpellings = new[] { "SD", "Republic of the Sudan", "Jumhūrīyat as-Sūdān" },
                    Region = "Africa",
                    SubRegion = "Northern Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Caf, CountryCodeIso3.Tcd, CountryCodeIso3.Egy, CountryCodeIso3.Eri, CountryCodeIso3.Eth, CountryCodeIso3.Lby, CountryCodeIso3.Ssd },
                    Landlocked = false,
                    Area = 1886068,
                };
            }
        }
        public static Country Senegal
        {
            get
            {
                return new Country
                {
                    CommonName = "Senegal",
                    OfficialName = "Republic of Senegal",
                    Tld = new[] { ".sn" },
                    CountryCode = CountryCode.Sn,
                    IsoNumeric = "686",
                    Iso3 = CountryCodeIso3.Sen,
                    Cioc = "SEN",
                    Currencies = new[] { "XOF" },
                    CallingCodes = new[] { "221" },
                    Capital = "Dakar",
                    AlternativeSpellings = new[] { "SN", "Republic of Senegal", "République du Sénégal" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Gmb, CountryCodeIso3.Gin, CountryCodeIso3.Gnb, CountryCodeIso3.Mli, CountryCodeIso3.Mrt },
                    Landlocked = false,
                    Area = 196722,
                };
            }
        }
        public static Country Singapore
        {
            get
            {
                return new Country
                {
                    CommonName = "Singapore",
                    OfficialName = "Republic of Singapore",
                    Tld = new[] { ".sg", ".新加坡", ".சிங்கப்பூர்" },
                    CountryCode = CountryCode.Sg,
                    IsoNumeric = "702",
                    Iso3 = CountryCodeIso3.Sgp,
                    Cioc = "SIN",
                    Currencies = new[] { "SGD" },
                    CallingCodes = new[] { "65" },
                    Capital = "Singapore",
                    AlternativeSpellings = new[] { "SG", "Singapura", "Republik Singapura", "新加坡共和国" },
                    Region = "Asia",
                    SubRegion = "South-Eastern Asia",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 710,
                };
            }
        }
        public static Country SouthGeorgia
        {
            get
            {
                return new Country
                {
                    CommonName = "South Georgia",
                    OfficialName = "South Georgia and the South Sandwich Islands",
                    Tld = new[] { ".gs" },
                    CountryCode = CountryCode.Gs,
                    IsoNumeric = "239",
                    Iso3 = CountryCodeIso3.Sgs,
                    Cioc = "",
                    Currencies = new[] { "GBP" },
                    CallingCodes = new[] { "500" },
                    Capital = "King Edward Point",
                    AlternativeSpellings = new[] { "GS", "South Georgia and the South Sandwich Islands" },
                    Region = "Americas",
                    SubRegion = "South America",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 3903,
                };
            }
        }
        public static Country SvalbardandJanMayen
        {
            get
            {
                return new Country
                {
                    CommonName = "Svalbard and Jan Mayen",
                    OfficialName = "Svalbard og Jan Mayen",
                    Tld = new[] { ".sj" },
                    CountryCode = CountryCode.Sj,
                    IsoNumeric = "744",
                    Iso3 = CountryCodeIso3.Sjm,
                    Cioc = "",
                    Currencies = new[] { "NOK" },
                    CallingCodes = new[] { "4779" },
                    Capital = "Longyearbyen",
                    AlternativeSpellings = new[] { "SJ", "Svalbard and Jan Mayen Islands" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = -1,
                };
            }
        }
        public static Country SolomonIslands
        {
            get
            {
                return new Country
                {
                    CommonName = "Solomon Islands",
                    OfficialName = "Solomon Islands",
                    Tld = new[] { ".sb" },
                    CountryCode = CountryCode.Sb,
                    IsoNumeric = "090",
                    Iso3 = CountryCodeIso3.Slb,
                    Cioc = "SOL",
                    Currencies = new[] { "SDB" },
                    CallingCodes = new[] { "677" },
                    Capital = "Honiara",
                    AlternativeSpellings = new[] { "SB" },
                    Region = "Oceania",
                    SubRegion = "Melanesia",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 28896,
                };
            }
        }
        public static Country SierraLeone
        {
            get
            {
                return new Country
                {
                    CommonName = "Sierra Leone",
                    OfficialName = "Republic of Sierra Leone",
                    Tld = new[] { ".sl" },
                    CountryCode = CountryCode.Sl,
                    IsoNumeric = "694",
                    Iso3 = CountryCodeIso3.Sle,
                    Cioc = "SLE",
                    Currencies = new[] { "SLL" },
                    CallingCodes = new[] { "232" },
                    Capital = "Freetown",
                    AlternativeSpellings = new[] { "SL", "Republic of Sierra Leone" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Gin, CountryCodeIso3.Lbr },
                    Landlocked = false,
                    Area = 71740,
                };
            }
        }
        public static Country ElSalvador
        {
            get
            {
                return new Country
                {
                    CommonName = "El Salvador",
                    OfficialName = "Republic of El Salvador",
                    Tld = new[] { ".sv" },
                    CountryCode = CountryCode.Sv,
                    IsoNumeric = "222",
                    Iso3 = CountryCodeIso3.Slv,
                    Cioc = "ESA",
                    Currencies = new[] { "SVC", "USD" },
                    CallingCodes = new[] { "503" },
                    Capital = "San Salvador",
                    AlternativeSpellings = new[] { "SV", "Republic of El Salvador", "República de El Salvador" },
                    Region = "Americas",
                    SubRegion = "Central America",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Gtm, CountryCodeIso3.Hnd },
                    Landlocked = false,
                    Area = 21041,
                };
            }
        }
        public static Country SanMarino
        {
            get
            {
                return new Country
                {
                    CommonName = "San Marino",
                    OfficialName = "Most Serene Republic of San Marino",
                    Tld = new[] { ".sm" },
                    CountryCode = CountryCode.Sm,
                    IsoNumeric = "674",
                    Iso3 = CountryCodeIso3.Smr,
                    Cioc = "SMR",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "378" },
                    Capital = "City of San Marino",
                    AlternativeSpellings = new[] { "SM", "Republic of San Marino", "Repubblica di San Marino" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Ita },
                    Landlocked = true,
                    Area = 61,
                };
            }
        }
        public static Country Somalia
        {
            get
            {
                return new Country
                {
                    CommonName = "Somalia",
                    OfficialName = "Federal Republic of Somalia",
                    Tld = new[] { ".so" },
                    CountryCode = CountryCode.So,
                    IsoNumeric = "706",
                    Iso3 = CountryCodeIso3.Som,
                    Cioc = "SOM",
                    Currencies = new[] { "SOS" },
                    CallingCodes = new[] { "252" },
                    Capital = "Mogadishu",
                    AlternativeSpellings = new[] { "SO", "aṣ-Ṣūmāl", "Federal Republic of Somalia", "Jamhuuriyadda Federaalka Soomaaliya", "Jumhūriyyat aṣ-Ṣūmāl al-Fiderāliyya" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Dji, CountryCodeIso3.Eth, CountryCodeIso3.Ken },
                    Landlocked = false,
                    Area = 637657,
                };
            }
        }
        public static Country SaintPierreandMiquelon
        {
            get
            {
                return new Country
                {
                    CommonName = "Saint Pierre and Miquelon",
                    OfficialName = "Saint Pierre and Miquelon",
                    Tld = new[] { ".pm" },
                    CountryCode = CountryCode.Pm,
                    IsoNumeric = "666",
                    Iso3 = CountryCodeIso3.Spm,
                    Cioc = "",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "508" },
                    Capital = "Saint-Pierre",
                    AlternativeSpellings = new[] { "PM", "Collectivité territoriale de Saint-Pierre-et-Miquelon" },
                    Region = "Americas",
                    SubRegion = "Northern America",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 242,
                };
            }
        }
        public static Country Serbia
        {
            get
            {
                return new Country
                {
                    CommonName = "Serbia",
                    OfficialName = "Republic of Serbia",
                    Tld = new[] { ".rs", ".срб" },
                    CountryCode = CountryCode.Rs,
                    IsoNumeric = "688",
                    Iso3 = CountryCodeIso3.Srb,
                    Cioc = "SRB",
                    Currencies = new[] { "RSD" },
                    CallingCodes = new[] { "381" },
                    Capital = "Belgrade",
                    AlternativeSpellings = new[] { "RS", "Srbija", "Republic of Serbia", "Република Србија", "Republika Srbija" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Bih, CountryCodeIso3.Bgr, CountryCodeIso3.Hrv, CountryCodeIso3.Hun, CountryCodeIso3.Kos, CountryCodeIso3.Mkd, CountryCodeIso3.Mne, CountryCodeIso3.Rou },
                    Landlocked = true,
                    Area = 88361,
                };
            }
        }
        public static Country SouthSudan
        {
            get
            {
                return new Country
                {
                    CommonName = "South Sudan",
                    OfficialName = "Republic of South Sudan",
                    Tld = new[] { ".ss" },
                    CountryCode = CountryCode.Ss,
                    IsoNumeric = "728",
                    Iso3 = CountryCodeIso3.Ssd,
                    Cioc = "",
                    Currencies = new[] { "SSP" },
                    CallingCodes = new[] { "211" },
                    Capital = "Juba",
                    AlternativeSpellings = new[] { "SS" },
                    Region = "Africa",
                    SubRegion = "Middle Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Caf, CountryCodeIso3.Cod, CountryCodeIso3.Eth, CountryCodeIso3.Ken, CountryCodeIso3.Sdn, CountryCodeIso3.Uga },
                    Landlocked = true,
                    Area = 619745,
                };
            }
        }
        public static Country SãoToméandPríncipe
        {
            get
            {
                return new Country
                {
                    CommonName = "São Tomé and Príncipe",
                    OfficialName = "Democratic Republic of São Tomé and Príncipe",
                    Tld = new[] { ".st" },
                    CountryCode = CountryCode.St,
                    IsoNumeric = "678",
                    Iso3 = CountryCodeIso3.Stp,
                    Cioc = "STP",
                    Currencies = new[] { "STD" },
                    CallingCodes = new[] { "239" },
                    Capital = "São Tomé",
                    AlternativeSpellings = new[] { "ST", "Democratic Republic of São Tomé and Príncipe", "Sao Tome and Principe", "República Democrática de São Tomé e Príncipe" },
                    Region = "Africa",
                    SubRegion = "Middle Africa",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 964,
                };
            }
        }
        public static Country Suriname
        {
            get
            {
                return new Country
                {
                    CommonName = "Suriname",
                    OfficialName = "Republic of Suriname",
                    Tld = new[] { ".sr" },
                    CountryCode = CountryCode.Sr,
                    IsoNumeric = "740",
                    Iso3 = CountryCodeIso3.Sur,
                    Cioc = "SUR",
                    Currencies = new[] { "SRD" },
                    CallingCodes = new[] { "597" },
                    Capital = "Paramaribo",
                    AlternativeSpellings = new[] { "SR", "Sarnam", "Sranangron", "Republic of Suriname", "Republiek Suriname" },
                    Region = "Americas",
                    SubRegion = "South America",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Bra, CountryCodeIso3.Guf, CountryCodeIso3.Guy },
                    Landlocked = false,
                    Area = 163820,
                };
            }
        }
        public static Country Slovakia
        {
            get
            {
                return new Country
                {
                    CommonName = "Slovakia",
                    OfficialName = "Slovak Republic",
                    Tld = new[] { ".sk" },
                    CountryCode = CountryCode.Sk,
                    IsoNumeric = "703",
                    Iso3 = CountryCodeIso3.Svk,
                    Cioc = "SVK",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "421" },
                    Capital = "Bratislava",
                    AlternativeSpellings = new[] { "SK", "Slovak Republic", "Slovenská republika" },
                    Region = "Europe",
                    SubRegion = "Eastern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Aut, CountryCodeIso3.Cze, CountryCodeIso3.Hun, CountryCodeIso3.Pol, CountryCodeIso3.Ukr },
                    Landlocked = true,
                    Area = 49037,
                };
            }
        }
        public static Country Slovenia
        {
            get
            {
                return new Country
                {
                    CommonName = "Slovenia",
                    OfficialName = "Republic of Slovenia",
                    Tld = new[] { ".si" },
                    CountryCode = CountryCode.Si,
                    IsoNumeric = "705",
                    Iso3 = CountryCodeIso3.Svn,
                    Cioc = "SLO",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "386" },
                    Capital = "Ljubljana",
                    AlternativeSpellings = new[] { "SI", "Republic of Slovenia", "Republika Slovenija" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Aut, CountryCodeIso3.Hrv, CountryCodeIso3.Ita, CountryCodeIso3.Hun },
                    Landlocked = false,
                    Area = 20273,
                };
            }
        }
        public static Country Sweden
        {
            get
            {
                return new Country
                {
                    CommonName = "Sweden",
                    OfficialName = "Kingdom of Sweden",
                    Tld = new[] { ".se" },
                    CountryCode = CountryCode.Se,
                    IsoNumeric = "752",
                    Iso3 = CountryCodeIso3.Swe,
                    Cioc = "SWE",
                    Currencies = new[] { "SEK" },
                    CallingCodes = new[] { "46" },
                    Capital = "Stockholm",
                    AlternativeSpellings = new[] { "SE", "Kingdom of Sweden", "Konungariket Sverige" },
                    Region = "Europe",
                    SubRegion = "Northern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Fin, CountryCodeIso3.Nor },
                    Landlocked = false,
                    Area = 450295,
                };
            }
        }
        public static Country Swaziland
        {
            get
            {
                return new Country
                {
                    CommonName = "Swaziland",
                    OfficialName = "Kingdom of Swaziland",
                    Tld = new[] { ".sz" },
                    CountryCode = CountryCode.Sz,
                    IsoNumeric = "748",
                    Iso3 = CountryCodeIso3.Swz,
                    Cioc = "SWZ",
                    Currencies = new[] { "SZL" },
                    CallingCodes = new[] { "268" },
                    Capital = "Lobamba",
                    AlternativeSpellings = new[] { "SZ", "weSwatini", "Swatini", "Ngwane", "Kingdom of Swaziland", "Umbuso waseSwatini" },
                    Region = "Africa",
                    SubRegion = "Southern Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Moz, CountryCodeIso3.Zaf },
                    Landlocked = true,
                    Area = 17364,
                };
            }
        }
        public static Country SintMaarten
        {
            get
            {
                return new Country
                {
                    CommonName = "Sint Maarten",
                    OfficialName = "Sint Maarten",
                    Tld = new[] { ".sx" },
                    CountryCode = CountryCode.Sx,
                    IsoNumeric = "534",
                    Iso3 = CountryCodeIso3.Sxm,
                    Cioc = "",
                    Currencies = new[] { "ANG" },
                    CallingCodes = new[] { "1721" },
                    Capital = "Philipsburg",
                    AlternativeSpellings = new[] { "SX", "Sint Maarten (Dutch part)" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Maf },
                    Landlocked = false,
                    Area = 34,
                };
            }
        }
        public static Country Seychelles
        {
            get
            {
                return new Country
                {
                    CommonName = "Seychelles",
                    OfficialName = "Republic of Seychelles",
                    Tld = new[] { ".sc" },
                    CountryCode = CountryCode.Sc,
                    IsoNumeric = "690",
                    Iso3 = CountryCodeIso3.Syc,
                    Cioc = "SEY",
                    Currencies = new[] { "SCR" },
                    CallingCodes = new[] { "248" },
                    Capital = "Victoria",
                    AlternativeSpellings = new[] { "SC", "Republic of Seychelles", "Repiblik Sesel", "République des Seychelles" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 452,
                };
            }
        }
        public static Country Syria
        {
            get
            {
                return new Country
                {
                    CommonName = "Syria",
                    OfficialName = "Syrian Arab Republic",
                    Tld = new[] { ".sy", "سوريا." },
                    CountryCode = CountryCode.Sy,
                    IsoNumeric = "760",
                    Iso3 = CountryCodeIso3.Syr,
                    Cioc = "SYR",
                    Currencies = new[] { "SYP" },
                    CallingCodes = new[] { "963" },
                    Capital = "Damascus",
                    AlternativeSpellings = new[] { "SY", "Syrian Arab Republic", "Al-Jumhūrīyah Al-ʻArabīyah As-Sūrīyah" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Irq, CountryCodeIso3.Isr, CountryCodeIso3.Jor, CountryCodeIso3.Lbn, CountryCodeIso3.Tur },
                    Landlocked = false,
                    Area = 185180,
                };
            }
        }
        public static Country TurksandCaicosIslands
        {
            get
            {
                return new Country
                {
                    CommonName = "Turks and Caicos Islands",
                    OfficialName = "Turks and Caicos Islands",
                    Tld = new[] { ".tc" },
                    CountryCode = CountryCode.Tc,
                    IsoNumeric = "796",
                    Iso3 = CountryCodeIso3.Tca,
                    Cioc = "",
                    Currencies = new[] { "USD" },
                    CallingCodes = new[] { "1649" },
                    Capital = "Cockburn Town",
                    AlternativeSpellings = new[] { "TC" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 948,
                };
            }
        }
        public static Country Chad
        {
            get
            {
                return new Country
                {
                    CommonName = "Chad",
                    OfficialName = "Republic of Chad",
                    Tld = new[] { ".td" },
                    CountryCode = CountryCode.Td,
                    IsoNumeric = "148",
                    Iso3 = CountryCodeIso3.Tcd,
                    Cioc = "CHA",
                    Currencies = new[] { "XAF" },
                    CallingCodes = new[] { "235" },
                    Capital = "N'Djamena",
                    AlternativeSpellings = new[] { "TD", "Tchad", "Republic of Chad", "République du Tchad" },
                    Region = "Africa",
                    SubRegion = "Middle Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Cmr, CountryCodeIso3.Caf, CountryCodeIso3.Lby, CountryCodeIso3.Ner, CountryCodeIso3.Nga, CountryCodeIso3.Ssd },
                    Landlocked = true,
                    Area = 1284000,
                };
            }
        }
        public static Country Togo
        {
            get
            {
                return new Country
                {
                    CommonName = "Togo",
                    OfficialName = "Togolese Republic",
                    Tld = new[] { ".tg" },
                    CountryCode = CountryCode.Tg,
                    IsoNumeric = "768",
                    Iso3 = CountryCodeIso3.Tgo,
                    Cioc = "TOG",
                    Currencies = new[] { "XOF" },
                    CallingCodes = new[] { "228" },
                    Capital = "Lomé",
                    AlternativeSpellings = new[] { "TG", "Togolese", "Togolese Republic", "République Togolaise" },
                    Region = "Africa",
                    SubRegion = "Western Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Ben, CountryCodeIso3.Bfa, CountryCodeIso3.Gha },
                    Landlocked = false,
                    Area = 56785,
                };
            }
        }
        public static Country Thailand
        {
            get
            {
                return new Country
                {
                    CommonName = "Thailand",
                    OfficialName = "Kingdom of Thailand",
                    Tld = new[] { ".th", ".ไทย" },
                    CountryCode = CountryCode.Th,
                    IsoNumeric = "764",
                    Iso3 = CountryCodeIso3.Tha,
                    Cioc = "THA",
                    Currencies = new[] { "THB" },
                    CallingCodes = new[] { "66" },
                    Capital = "Bangkok",
                    AlternativeSpellings = new[] { "TH", "Prathet", "Thai", "Kingdom of Thailand", "ราชอาณาจักรไทย", "Ratcha Anachak Thai" },
                    Region = "Asia",
                    SubRegion = "South-Eastern Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Mmr, CountryCodeIso3.Khm, CountryCodeIso3.Lao, CountryCodeIso3.Mys },
                    Landlocked = false,
                    Area = 513120,
                };
            }
        }
        public static Country Tajikistan
        {
            get
            {
                return new Country
                {
                    CommonName = "Tajikistan",
                    OfficialName = "Republic of Tajikistan",
                    Tld = new[] { ".tj" },
                    CountryCode = CountryCode.Tj,
                    IsoNumeric = "762",
                    Iso3 = CountryCodeIso3.Tjk,
                    Cioc = "TJK",
                    Currencies = new[] { "TJS" },
                    CallingCodes = new[] { "992" },
                    Capital = "Dushanbe",
                    AlternativeSpellings = new[] { "TJ", "Toçikiston", "Republic of Tajikistan", "Ҷумҳурии Тоҷикистон", "Çumhuriyi Toçikiston" },
                    Region = "Asia",
                    SubRegion = "Central Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Afg, CountryCodeIso3.Chn, CountryCodeIso3.Kgz, CountryCodeIso3.Uzb },
                    Landlocked = true,
                    Area = 143100,
                };
            }
        }
        public static Country Tokelau
        {
            get
            {
                return new Country
                {
                    CommonName = "Tokelau",
                    OfficialName = "Tokelau",
                    Tld = new[] { ".tk" },
                    CountryCode = CountryCode.Tk,
                    IsoNumeric = "772",
                    Iso3 = CountryCodeIso3.Tkl,
                    Cioc = "",
                    Currencies = new[] { "NZD" },
                    CallingCodes = new[] { "690" },
                    Capital = "Fakaofo",
                    AlternativeSpellings = new[] { "TK" },
                    Region = "Oceania",
                    SubRegion = "Polynesia",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 12,
                };
            }
        }
        public static Country Turkmenistan
        {
            get
            {
                return new Country
                {
                    CommonName = "Turkmenistan",
                    OfficialName = "Turkmenistan",
                    Tld = new[] { ".tm" },
                    CountryCode = CountryCode.Tm,
                    IsoNumeric = "795",
                    Iso3 = CountryCodeIso3.Tkm,
                    Cioc = "TKM",
                    Currencies = new[] { "TMT" },
                    CallingCodes = new[] { "993" },
                    Capital = "Ashgabat",
                    AlternativeSpellings = new[] { "TM" },
                    Region = "Asia",
                    SubRegion = "Central Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Afg, CountryCodeIso3.Irn, CountryCodeIso3.Kaz, CountryCodeIso3.Uzb },
                    Landlocked = true,
                    Area = 488100,
                };
            }
        }
        public static Country TimorLeste
        {
            get
            {
                return new Country
                {
                    CommonName = "Timor-Leste",
                    OfficialName = "Democratic Republic of Timor-Leste",
                    Tld = new[] { ".tl" },
                    CountryCode = CountryCode.Tl,
                    IsoNumeric = "626",
                    Iso3 = CountryCodeIso3.Tls,
                    Cioc = "TLS",
                    Currencies = new[] { "USD" },
                    CallingCodes = new[] { "670" },
                    Capital = "Dili",
                    AlternativeSpellings = new[] { "TL", "East Timor", "Democratic Republic of Timor-Leste", "República Democrática de Timor-Leste", "Repúblika Demokrátika Timór-Leste", "Timór Lorosa'e", "Timor Lorosae" },
                    Region = "Asia",
                    SubRegion = "South-Eastern Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Idn },
                    Landlocked = false,
                    Area = 14874,
                };
            }
        }
        public static Country Tonga
        {
            get
            {
                return new Country
                {
                    CommonName = "Tonga",
                    OfficialName = "Kingdom of Tonga",
                    Tld = new[] { ".to" },
                    CountryCode = CountryCode.To,
                    IsoNumeric = "776",
                    Iso3 = CountryCodeIso3.Ton,
                    Cioc = "TGA",
                    Currencies = new[] { "TOP" },
                    CallingCodes = new[] { "676" },
                    Capital = "Nuku'alofa",
                    AlternativeSpellings = new[] { "TO" },
                    Region = "Oceania",
                    SubRegion = "Polynesia",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 747,
                };
            }
        }
        public static Country TrinidadandTobago
        {
            get
            {
                return new Country
                {
                    CommonName = "Trinidad and Tobago",
                    OfficialName = "Republic of Trinidad and Tobago",
                    Tld = new[] { ".tt" },
                    CountryCode = CountryCode.Tt,
                    IsoNumeric = "780",
                    Iso3 = CountryCodeIso3.Tto,
                    Cioc = "TTO",
                    Currencies = new[] { "TTD" },
                    CallingCodes = new[] { "1868" },
                    Capital = "Port of Spain",
                    AlternativeSpellings = new[] { "TT", "Republic of Trinidad and Tobago" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 5130,
                };
            }
        }
        public static Country Tunisia
        {
            get
            {
                return new Country
                {
                    CommonName = "Tunisia",
                    OfficialName = "Tunisian Republic",
                    Tld = new[] { ".tn" },
                    CountryCode = CountryCode.Tn,
                    IsoNumeric = "788",
                    Iso3 = CountryCodeIso3.Tun,
                    Cioc = "TUN",
                    Currencies = new[] { "TND" },
                    CallingCodes = new[] { "216" },
                    Capital = "Tunis",
                    AlternativeSpellings = new[] { "TN", "Republic of Tunisia", "al-Jumhūriyyah at-Tūnisiyyah" },
                    Region = "Africa",
                    SubRegion = "Northern Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Dza, CountryCodeIso3.Lby },
                    Landlocked = false,
                    Area = 163610,
                };
            }
        }
        public static Country Turkey
        {
            get
            {
                return new Country
                {
                    CommonName = "Turkey",
                    OfficialName = "Republic of Turkey",
                    Tld = new[] { ".tr" },
                    CountryCode = CountryCode.Tr,
                    IsoNumeric = "792",
                    Iso3 = CountryCodeIso3.Tur,
                    Cioc = "TUR",
                    Currencies = new[] { "TRY" },
                    CallingCodes = new[] { "90" },
                    Capital = "Ankara",
                    AlternativeSpellings = new[] { "TR", "Turkiye", "Republic of Turkey", "Türkiye Cumhuriyeti" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Arm, CountryCodeIso3.Aze, CountryCodeIso3.Bgr, CountryCodeIso3.Geo, CountryCodeIso3.Grc, CountryCodeIso3.Irn, CountryCodeIso3.Irq, CountryCodeIso3.Syr },
                    Landlocked = false,
                    Area = 783562,
                };
            }
        }
        public static Country Tuvalu
        {
            get
            {
                return new Country
                {
                    CommonName = "Tuvalu",
                    OfficialName = "Tuvalu",
                    Tld = new[] { ".tv" },
                    CountryCode = CountryCode.Tv,
                    IsoNumeric = "798",
                    Iso3 = CountryCodeIso3.Tuv,
                    Cioc = "TUV",
                    Currencies = new[] { "AUD" },
                    CallingCodes = new[] { "688" },
                    Capital = "Funafuti",
                    AlternativeSpellings = new[] { "TV" },
                    Region = "Oceania",
                    SubRegion = "Polynesia",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 26,
                };
            }
        }
        public static Country Taiwan
        {
            get
            {
                return new Country
                {
                    CommonName = "Taiwan",
                    OfficialName = "Republic of China",
                    Tld = new[] { ".tw", ".台湾", ".台灣" },
                    CountryCode = CountryCode.Tw,
                    IsoNumeric = "158",
                    Iso3 = CountryCodeIso3.Twn,
                    Cioc = "TPE",
                    Currencies = new[] { "TWD" },
                    CallingCodes = new[] { "886" },
                    Capital = "Taipei",
                    AlternativeSpellings = new[] { "TW", "Táiwān", "Republic of China", "中華民國", "Zhōnghuá Mínguó", "Chinese Taipei for IOC", "Taiwan, Province of China" },
                    Region = "Asia",
                    SubRegion = "Eastern Asia",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 36193,
                };
            }
        }
        public static Country Tanzania
        {
            get
            {
                return new Country
                {
                    CommonName = "Tanzania",
                    OfficialName = "United Republic of Tanzania",
                    Tld = new[] { ".tz" },
                    CountryCode = CountryCode.Tz,
                    IsoNumeric = "834",
                    Iso3 = CountryCodeIso3.Tza,
                    Cioc = "TAN",
                    Currencies = new[] { "TZS" },
                    CallingCodes = new[] { "255" },
                    Capital = "Dodoma",
                    AlternativeSpellings = new[] { "TZ", "Tanzania, United Republic of", "United Republic of Tanzania", "Jamhuri ya Muungano wa Tanzania" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Bdi, CountryCodeIso3.Cod, CountryCodeIso3.Ken, CountryCodeIso3.Mwi, CountryCodeIso3.Moz, CountryCodeIso3.Rwa, CountryCodeIso3.Uga, CountryCodeIso3.Zmb },
                    Landlocked = false,
                    Area = 945087,
                };
            }
        }
        public static Country Uganda
        {
            get
            {
                return new Country
                {
                    CommonName = "Uganda",
                    OfficialName = "Republic of Uganda",
                    Tld = new[] { ".ug" },
                    CountryCode = CountryCode.Ug,
                    IsoNumeric = "800",
                    Iso3 = CountryCodeIso3.Uga,
                    Cioc = "UGA",
                    Currencies = new[] { "UGX" },
                    CallingCodes = new[] { "256" },
                    Capital = "Kampala",
                    AlternativeSpellings = new[] { "UG", "Republic of Uganda", "Jamhuri ya Uganda" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Cod, CountryCodeIso3.Ken, CountryCodeIso3.Rwa, CountryCodeIso3.Ssd, CountryCodeIso3.Tza },
                    Landlocked = true,
                    Area = 241550,
                };
            }
        }
        public static Country Ukraine
        {
            get
            {
                return new Country
                {
                    CommonName = "Ukraine",
                    OfficialName = "Ukraine",
                    Tld = new[] { ".ua", ".укр" },
                    CountryCode = CountryCode.Ua,
                    IsoNumeric = "804",
                    Iso3 = CountryCodeIso3.Ukr,
                    Cioc = "UKR",
                    Currencies = new[] { "UAH" },
                    CallingCodes = new[] { "380" },
                    Capital = "Kiev",
                    AlternativeSpellings = new[] { "UA", "Ukrayina" },
                    Region = "Europe",
                    SubRegion = "Eastern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Blr, CountryCodeIso3.Hun, CountryCodeIso3.Mda, CountryCodeIso3.Pol, CountryCodeIso3.Rou, CountryCodeIso3.Rus, CountryCodeIso3.Svk },
                    Landlocked = false,
                    Area = 603500,
                };
            }
        }
        public static Country UnitedStatesMinorOutlyingIslands
        {
            get
            {
                return new Country
                {
                    CommonName = "United States Minor Outlying Islands",
                    OfficialName = "United States Minor Outlying Islands",
                    Tld = new[] { ".us" },
                    CountryCode = CountryCode.Um,
                    IsoNumeric = "581",
                    Iso3 = CountryCodeIso3.Umi,
                    Cioc = "",
                    Currencies = new[] { "USD" },
                    Capital = "",
                    AlternativeSpellings = new[] { "UM" },
                    Region = "Americas",
                    SubRegion = "Northern America",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 34,
                };
            }
        }
        public static Country Uruguay
        {
            get
            {
                return new Country
                {
                    CommonName = "Uruguay",
                    OfficialName = "Oriental Republic of Uruguay",
                    Tld = new[] { ".uy" },
                    CountryCode = CountryCode.Uy,
                    IsoNumeric = "858",
                    Iso3 = CountryCodeIso3.Ury,
                    Cioc = "URU",
                    Currencies = new[] { "UYI", "UYU" },
                    CallingCodes = new[] { "598" },
                    Capital = "Montevideo",
                    AlternativeSpellings = new[] { "UY", "Oriental Republic of Uruguay", "República Oriental del Uruguay" },
                    Region = "Americas",
                    SubRegion = "South America",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Arg, CountryCodeIso3.Bra },
                    Landlocked = false,
                    Area = 181034,
                };
            }
        }
        public static Country UnitedStates
        {
            get
            {
                return new Country
                {
                    CommonName = "United States",
                    OfficialName = "United States of America",
                    Tld = new[] { ".us" },
                    CountryCode = CountryCode.Us,
                    IsoNumeric = "840",
                    Iso3 = CountryCodeIso3.Usa,
                    Cioc = "USA",
                    Currencies = new[] { "USD", "USN", "USS" },
                    CallingCodes = new[] { "1" },
                    Capital = "Washington D.C.",
                    AlternativeSpellings = new[] { "US", "USA", "United States of America" },
                    Region = "Americas",
                    SubRegion = "Northern America",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Can, CountryCodeIso3.Mex },
                    Landlocked = false,
                    Area = 9372610,
                };
            }
        }
        public static Country Uzbekistan
        {
            get
            {
                return new Country
                {
                    CommonName = "Uzbekistan",
                    OfficialName = "Republic of Uzbekistan",
                    Tld = new[] { ".uz" },
                    CountryCode = CountryCode.Uz,
                    IsoNumeric = "860",
                    Iso3 = CountryCodeIso3.Uzb,
                    Cioc = "UZB",
                    Currencies = new[] { "UZS" },
                    CallingCodes = new[] { "998" },
                    Capital = "Tashkent",
                    AlternativeSpellings = new[] { "UZ", "Republic of Uzbekistan", "O‘zbekiston Respublikasi", "Ўзбекистон Республикаси" },
                    Region = "Asia",
                    SubRegion = "Central Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Afg, CountryCodeIso3.Kaz, CountryCodeIso3.Kgz, CountryCodeIso3.Tjk, CountryCodeIso3.Tkm },
                    Landlocked = true,
                    Area = 447400,
                };
            }
        }
        public static Country VaticanCity
        {
            get
            {
                return new Country
                {
                    CommonName = "Vatican City",
                    OfficialName = "Vatican City State",
                    Tld = new[] { ".va" },
                    CountryCode = CountryCode.Va,
                    IsoNumeric = "336",
                    Iso3 = CountryCodeIso3.Vat,
                    Cioc = "",
                    Currencies = new[] { "EUR" },
                    CallingCodes = new[] { "3906698", "379" },
                    Capital = "Vatican City",
                    AlternativeSpellings = new[] { "VA", "Holy See (Vatican City State)", "Vatican City State", "Stato della Città del Vaticano" },
                    Region = "Europe",
                    SubRegion = "Southern Europe",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Ita },
                    Landlocked = true,
                    Area = 0,
                };
            }
        }
        public static Country SaintVincentandtheGrenadines
        {
            get
            {
                return new Country
                {
                    CommonName = "Saint Vincent and the Grenadines",
                    OfficialName = "Saint Vincent and the Grenadines",
                    Tld = new[] { ".vc" },
                    CountryCode = CountryCode.Vc,
                    IsoNumeric = "670",
                    Iso3 = CountryCodeIso3.Vct,
                    Cioc = "VIN",
                    Currencies = new[] { "XCD" },
                    CallingCodes = new[] { "1784" },
                    Capital = "Kingstown",
                    AlternativeSpellings = new[] { "VC" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 389,
                };
            }
        }
        public static Country Venezuela
        {
            get
            {
                return new Country
                {
                    CommonName = "Venezuela",
                    OfficialName = "Bolivarian Republic of Venezuela",
                    Tld = new[] { ".ve" },
                    CountryCode = CountryCode.Ve,
                    IsoNumeric = "862",
                    Iso3 = CountryCodeIso3.Ven,
                    Cioc = "VEN",
                    Currencies = new[] { "VEF" },
                    CallingCodes = new[] { "58" },
                    Capital = "Caracas",
                    AlternativeSpellings = new[] { "VE", "Bolivarian Republic of Venezuela", "Venezuela, Bolivarian Republic of", "República Bolivariana de Venezuela" },
                    Region = "Americas",
                    SubRegion = "South America",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Bra, CountryCodeIso3.Col, CountryCodeIso3.Guy },
                    Landlocked = false,
                    Area = 916445,
                };
            }
        }
        public static Country BritishVirginIslands
        {
            get
            {
                return new Country
                {
                    CommonName = "British Virgin Islands",
                    OfficialName = "Virgin Islands",
                    Tld = new[] { ".vg" },
                    CountryCode = CountryCode.Vg,
                    IsoNumeric = "092",
                    Iso3 = CountryCodeIso3.Vgb,
                    Cioc = "IVB",
                    Currencies = new[] { "USD" },
                    CallingCodes = new[] { "1284" },
                    Capital = "Road Town",
                    AlternativeSpellings = new[] { "VG", "Virgin Islands, British" },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 151,
                };
            }
        }
        public static Country UnitedStatesVirginIslands
        {
            get
            {
                return new Country
                {
                    CommonName = "United States Virgin Islands",
                    OfficialName = "Virgin Islands of the United States",
                    Tld = new[] { ".vi" },
                    CountryCode = CountryCode.Vi,
                    IsoNumeric = "850",
                    Iso3 = CountryCodeIso3.Vir,
                    Cioc = "ISV",
                    Currencies = new[] { "USD" },
                    CallingCodes = new[] { "1340" },
                    Capital = "Charlotte Amalie",
                    AlternativeSpellings = new[] { "VI", "Virgin Islands, U.S." },
                    Region = "Americas",
                    SubRegion = "Caribbean",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 347,
                };
            }
        }
        public static Country Vietnam
        {
            get
            {
                return new Country
                {
                    CommonName = "Vietnam",
                    OfficialName = "Socialist Republic of Vietnam",
                    Tld = new[] { ".vn" },
                    CountryCode = CountryCode.Vn,
                    IsoNumeric = "704",
                    Iso3 = CountryCodeIso3.Vnm,
                    Cioc = "VIE",
                    Currencies = new[] { "VND" },
                    CallingCodes = new[] { "84" },
                    Capital = "Hanoi",
                    AlternativeSpellings = new[] { "VN", "Socialist Republic of Vietnam", "Cộng hòa Xã hội chủ nghĩa Việt Nam", "Viet Nam" },
                    Region = "Asia",
                    SubRegion = "South-Eastern Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Khm, CountryCodeIso3.Chn, CountryCodeIso3.Lao },
                    Landlocked = false,
                    Area = 331212,
                };
            }
        }
        public static Country Vanuatu
        {
            get
            {
                return new Country
                {
                    CommonName = "Vanuatu",
                    OfficialName = "Republic of Vanuatu",
                    Tld = new[] { ".vu" },
                    CountryCode = CountryCode.Vu,
                    IsoNumeric = "548",
                    Iso3 = CountryCodeIso3.Vut,
                    Cioc = "VAN",
                    Currencies = new[] { "VUV" },
                    CallingCodes = new[] { "678" },
                    Capital = "Port Vila",
                    AlternativeSpellings = new[] { "VU", "Republic of Vanuatu", "Ripablik blong Vanuatu", "République de Vanuatu" },
                    Region = "Oceania",
                    SubRegion = "Melanesia",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 12189,
                };
            }
        }
        public static Country WallisandFutuna
        {
            get
            {
                return new Country
                {
                    CommonName = "Wallis and Futuna",
                    OfficialName = "Territory of the Wallis and Futuna Islands",
                    Tld = new[] { ".wf" },
                    CountryCode = CountryCode.Wf,
                    IsoNumeric = "876",
                    Iso3 = CountryCodeIso3.Wlf,
                    Cioc = "",
                    Currencies = new[] { "XPF" },
                    CallingCodes = new[] { "681" },
                    Capital = "Mata-Utu",
                    AlternativeSpellings = new[] { "WF", "Territory of the Wallis and Futuna Islands", "Territoire des îles Wallis et Futuna" },
                    Region = "Oceania",
                    SubRegion = "Polynesia",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 142,
                };
            }
        }
        public static Country Samoa
        {
            get
            {
                return new Country
                {
                    CommonName = "Samoa",
                    OfficialName = "Independent State of Samoa",
                    Tld = new[] { ".ws" },
                    CountryCode = CountryCode.Ws,
                    IsoNumeric = "882",
                    Iso3 = CountryCodeIso3.Wsm,
                    Cioc = "SAM",
                    Currencies = new[] { "WST" },
                    CallingCodes = new[] { "685" },
                    Capital = "Apia",
                    AlternativeSpellings = new[] { "WS", "Independent State of Samoa", "Malo Saʻoloto Tutoʻatasi o Sāmoa" },
                    Region = "Oceania",
                    SubRegion = "Polynesia",
                    Borders = new CountryCodeIso3[] { },
                    Landlocked = false,
                    Area = 2842,
                };
            }
        }
        public static Country Yemen
        {
            get
            {
                return new Country
                {
                    CommonName = "Yemen",
                    OfficialName = "Republic of Yemen",
                    Tld = new[] { ".ye" },
                    CountryCode = CountryCode.Ye,
                    IsoNumeric = "887",
                    Iso3 = CountryCodeIso3.Yem,
                    Cioc = "YEM",
                    Currencies = new[] { "YER" },
                    CallingCodes = new[] { "967" },
                    Capital = "Sana'a",
                    AlternativeSpellings = new[] { "YE", "Yemeni Republic", "al-Jumhūriyyah al-Yamaniyyah" },
                    Region = "Asia",
                    SubRegion = "Western Asia",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Omn, CountryCodeIso3.Sau },
                    Landlocked = false,
                    Area = 527968,
                };
            }
        }
        public static Country SouthAfrica
        {
            get
            {
                return new Country
                {
                    CommonName = "South Africa",
                    OfficialName = "Republic of South Africa",
                    Tld = new[] { ".za" },
                    CountryCode = CountryCode.Za,
                    IsoNumeric = "710",
                    Iso3 = CountryCodeIso3.Zaf,
                    Cioc = "RSA",
                    Currencies = new[] { "ZAR" },
                    CallingCodes = new[] { "27" },
                    Capital = "Pretoria",
                    AlternativeSpellings = new[] { "ZA", "RSA", "Suid-Afrika", "Republic of South Africa" },
                    Region = "Africa",
                    SubRegion = "Southern Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Bwa, CountryCodeIso3.Lso, CountryCodeIso3.Moz, CountryCodeIso3.Nam, CountryCodeIso3.Swz, CountryCodeIso3.Zwe },
                    Landlocked = false,
                    Area = 1221037,
                };
            }
        }
        public static Country Zambia
        {
            get
            {
                return new Country
                {
                    CommonName = "Zambia",
                    OfficialName = "Republic of Zambia",
                    Tld = new[] { ".zm" },
                    CountryCode = CountryCode.Zm,
                    IsoNumeric = "894",
                    Iso3 = CountryCodeIso3.Zmb,
                    Cioc = "ZAM",
                    Currencies = new[] { "ZMW" },
                    CallingCodes = new[] { "260" },
                    Capital = "Lusaka",
                    AlternativeSpellings = new[] { "ZM", "Republic of Zambia" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Ago, CountryCodeIso3.Bwa, CountryCodeIso3.Cod, CountryCodeIso3.Mwi, CountryCodeIso3.Moz, CountryCodeIso3.Nam, CountryCodeIso3.Tza, CountryCodeIso3.Zwe },
                    Landlocked = true,
                    Area = 752612,
                };
            }
        }
        public static Country Zimbabwe
        {
            get
            {
                return new Country
                {
                    CommonName = "Zimbabwe",
                    OfficialName = "Republic of Zimbabwe",
                    Tld = new[] { ".zw" },
                    CountryCode = CountryCode.Zw,
                    IsoNumeric = "716",
                    Iso3 = CountryCodeIso3.Zwe,
                    Cioc = "ZIM",
                    Currencies = new[] { "ZWL" },
                    CallingCodes = new[] { "263" },
                    Capital = "Harare",
                    AlternativeSpellings = new[] { "ZW", "Republic of Zimbabwe" },
                    Region = "Africa",
                    SubRegion = "Eastern Africa",
                    Borders = new CountryCodeIso3[] { CountryCodeIso3.Bwa, CountryCodeIso3.Moz, CountryCodeIso3.Zaf, CountryCodeIso3.Zmb },
                    Landlocked = true,
                    Area = 390757,
                };
            }
        }
    }
}