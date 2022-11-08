﻿namespace MapleGriffin.CurrencyCodes
{
    public static class Countries
    {
        public static CountryCode FromName(string countryName)
        {
            return countryName.ToLowerInvariant() switch
            {
                "afghanistan" => CountryCode.AF,
                "albania" => CountryCode.AL,
                "algeria" => CountryCode.DZ,
                "american samoa" => CountryCode.AS,
                "andorra" => CountryCode.AD,
                "angola" => CountryCode.AO,
                "anguilla" => CountryCode.AI,
                "antigua and barbuda" => CountryCode.AG,
                "argentina" => CountryCode.AR,
                "armenia" => CountryCode.AM,
                "aruba" => CountryCode.AW,
                "australia" => CountryCode.AU,
                "austria" => CountryCode.AT,
                "azerbaijan" => CountryCode.AZ,
                "the bahamas" => CountryCode.BS,
                "bahamas" => CountryCode.BS,
                "bahrain" => CountryCode.BH,
                "bangladesh" => CountryCode.BD,
                "barbados" => CountryCode.BB,
                "belarus" => CountryCode.BY,
                "belgium" => CountryCode.BE,
                "belize" => CountryCode.BZ,
                "benin" => CountryCode.BJ,
                "bermuda" => CountryCode.BM,
                "bhutan" => CountryCode.BT,
                "bolivia" => CountryCode.BO,
                "bonaire" => CountryCode.BQ,
                "bosnia and herzegovina" => CountryCode.BA,
                "botswana" => CountryCode.BW,
                "bouvet island" => CountryCode.BV,
                "brazil" => CountryCode.BR,
                "british indian ocean territory" => CountryCode.IO,
                "brunei" => CountryCode.BN,
                "bulgaria" => CountryCode.BG,
                "burkina faso" => CountryCode.BF,
                "burundi" => CountryCode.BI,
                "cape verde" => CountryCode.CV,
                "cambodia" => CountryCode.KH,
                "cameroon" => CountryCode.CM,
                "canada" => CountryCode.CA,
                "cayman islands" => CountryCode.KY,
                "central african republic" => CountryCode.CF,
                "chad" => CountryCode.TD,
                "chile" => CountryCode.CL,
                "china" => CountryCode.CN,
                "christmas island" => CountryCode.CX,
                "cocos (keeling) islands" => CountryCode.CC,
                "colombia" => CountryCode.CO,
                "comoros" => CountryCode.KM,
                "democratic republic of the congo" => CountryCode.CD,
                "republic of the congo" => CountryCode.CG,
                "cook islands" => CountryCode.CK,
                "costa rica" => CountryCode.CR,
                "croatia" => CountryCode.HR,
                "cuba" => CountryCode.CU,
                "curaçao" => CountryCode.CW,
                "cyprus" => CountryCode.CY,
                "czech republic" => CountryCode.CZ,
                "ivory coast" => CountryCode.CI,
                "denmark" => CountryCode.DK,
                "djibouti" => CountryCode.DJ,
                "dominica" => CountryCode.DM,
                "dominican republic" => CountryCode.DO,
                "ecuador" => CountryCode.EC,
                "egypt" => CountryCode.EG,
                "el salvador" => CountryCode.SV,
                "equatorial guinea" => CountryCode.GQ,
                "eritrea" => CountryCode.ER,
                "estonia" => CountryCode.EE,
                "ethiopia" => CountryCode.ET,
                "falkland islands" => CountryCode.FK,
                "faroe islands" => CountryCode.FO,
                "fiji" => CountryCode.FJ,
                "finland" => CountryCode.FI,
                "france" => CountryCode.FR,
                "french guiana" => CountryCode.GF,
                "french polynesia" => CountryCode.PF,
                "french southern and antarctic lands" => CountryCode.TF,
                "gabon" => CountryCode.GA,
                "the gambia" => CountryCode.GM,
                "georgia" => CountryCode.GE,
                "germany" => CountryCode.DE,
                "ghana" => CountryCode.GH,
                "gibraltar" => CountryCode.GI,
                "greece" => CountryCode.GR,
                "greenland" => CountryCode.GL,
                "grenada" => CountryCode.GD,
                "guadeloupe" => CountryCode.GP,
                "guam" => CountryCode.GU,
                "guatemala" => CountryCode.GT,
                "bailiwick of guernsey" => CountryCode.GG,
                "guinea" => CountryCode.GN,
                "guinea-bissau" => CountryCode.GW,
                "guyana" => CountryCode.GY,
                "haiti" => CountryCode.HT,
                "heard island and mcdonald islands" => CountryCode.HM,
                "holy see" => CountryCode.VA,
                "honduras" => CountryCode.HN,
                "hong kong" => CountryCode.HK,
                "hungary" => CountryCode.HU,
                "iceland" => CountryCode.IS,
                "india" => CountryCode.IN,
                "indonesia" => CountryCode.ID,
                "iran" => CountryCode.IR,
                "iraq" => CountryCode.IQ,
                "republic of ireland" => CountryCode.IE,
                "isle of man" => CountryCode.IM,
                "israel" => CountryCode.IL,
                "italy" => CountryCode.IT,
                "jamaica" => CountryCode.JM,
                "japan" => CountryCode.JP,
                "jersey" => CountryCode.JE,
                "jordan" => CountryCode.JO,
                "kazakhstan" => CountryCode.KZ,
                "kenya" => CountryCode.KE,
                "kiribati" => CountryCode.KI,
                "north korea" => CountryCode.KP,
                "south korea" => CountryCode.KR,
                "kuwait" => CountryCode.KW,
                "kyrgyzstan" => CountryCode.KG,
                "laos" => CountryCode.LA,
                "latvia" => CountryCode.LV,
                "lebanon" => CountryCode.LB,
                "lesotho" => CountryCode.LS,
                "liberia" => CountryCode.LR,
                "libya" => CountryCode.LY,
                "liechtenstein" => CountryCode.LI,
                "lithuania" => CountryCode.LT,
                "luxembourg" => CountryCode.LU,
                "macau" => CountryCode.MO,
                "madagascar" => CountryCode.MG,
                "malawi" => CountryCode.MW,
                "malaysia" => CountryCode.MY,
                "maldives" => CountryCode.MV,
                "mali" => CountryCode.ML,
                "malta" => CountryCode.MT,
                "marshall islands" => CountryCode.MH,
                "martinique" => CountryCode.MQ,
                "mauritania" => CountryCode.MR,
                "mauritius" => CountryCode.MU,
                "mayotte" => CountryCode.YT,
                "mexico" => CountryCode.MX,
                "federated states of micronesia" => CountryCode.FM,
                "moldova" => CountryCode.MD,
                "monaco" => CountryCode.MC,
                "mongolia" => CountryCode.MN,
                "montenegro" => CountryCode.ME,
                "montserrat" => CountryCode.MS,
                "morocco" => CountryCode.MA,
                "mozambique" => CountryCode.MZ,
                "myanmar" => CountryCode.MM,
                "namibia" => CountryCode.NA,
                "nauru" => CountryCode.NR,
                "nepal" => CountryCode.NP,
                "netherlands" => CountryCode.NL,
                "new caledonia" => CountryCode.NC,
                "new zealand" => CountryCode.NZ,
                "nicaragua" => CountryCode.NI,
                "niger" => CountryCode.NE,
                "nigeria" => CountryCode.NG,
                "niue" => CountryCode.NU,
                "norfolk island" => CountryCode.NF,
                "northern mariana islands" => CountryCode.MP,
                "norway" => CountryCode.NO,
                "oman" => CountryCode.OM,
                "pakistan" => CountryCode.PK,
                "palau" => CountryCode.PW,
                "panama" => CountryCode.PA,
                "papua new guinea" => CountryCode.PG,
                "paraguay" => CountryCode.PY,
                "peru" => CountryCode.PE,
                "philippines" => CountryCode.PH,
                "pitcairn islands" => CountryCode.PN,
                "poland" => CountryCode.PL,
                "portugal" => CountryCode.PT,
                "puerto rico" => CountryCode.PR,
                "qatar" => CountryCode.QA,
                "north macedonia" => CountryCode.MK,
                "romania" => CountryCode.RO,
                "russia" => CountryCode.RU,
                "rwanda" => CountryCode.RW,
                "réunion" => CountryCode.RE,
                "saint barthélemy" => CountryCode.BL,
                "saint helena" => CountryCode.SH,
                "saint kitts and nevis" => CountryCode.KN,
                "saint lucia" => CountryCode.LC,
                "collectivity of saint martin" => CountryCode.MF,
                "saint pierre and miquelon" => CountryCode.PM,
                "saint vincent and the grenadines" => CountryCode.VC,
                "samoa" => CountryCode.WS,
                "san marino" => CountryCode.SM,
                "são tomé and príncipe" => CountryCode.ST,
                "saudi arabia" => CountryCode.SA,
                "senegal" => CountryCode.SN,
                "serbia" => CountryCode.RS,
                "seychelles" => CountryCode.SC,
                "sierra leone" => CountryCode.SL,
                "singapore" => CountryCode.SG,
                "sint maarten" => CountryCode.SX,
                "slovakia" => CountryCode.SK,
                "slovenia" => CountryCode.SI,
                "solomon islands" => CountryCode.SB,
                "somalia" => CountryCode.SO,
                "south africa" => CountryCode.ZA,
                "south sudan" => CountryCode.SS,
                "spain" => CountryCode.ES,
                "sri lanka" => CountryCode.LK,
                "sudan" => CountryCode.SD,
                "suriname" => CountryCode.SR,
                "svalbard" => CountryCode.SJ,
                "eswatini" => CountryCode.SZ,
                "sweden" => CountryCode.SE,
                "switzerland" => CountryCode.CH,
                "syria" => CountryCode.SY,
                "taiwan" => CountryCode.TW,
                "tajikistan" => CountryCode.TJ,
                "tanzania" => CountryCode.TZ,
                "thailand" => CountryCode.TH,
                "east timor" => CountryCode.TL,
                "togo" => CountryCode.TG,
                "tokelau" => CountryCode.TK,
                "tonga" => CountryCode.TO,
                "trinidad and tobago" => CountryCode.TT,
                "tunisia" => CountryCode.TN,
                "turkey" => CountryCode.TR,
                "turkmenistan" => CountryCode.TM,
                "turks and caicos islands" => CountryCode.TC,
                "tuvalu" => CountryCode.TV,
                "uganda" => CountryCode.UG,
                "ukraine" => CountryCode.UA,
                "united arab emirates" => CountryCode.AE,
                "united kingdom" => CountryCode.GB,
                "uk" => CountryCode.GB,
                "great brittain" => CountryCode.GB,
                "united states" => CountryCode.US,
                "united states of america" => CountryCode.US,
                "us" => CountryCode.US,
                "usa" => CountryCode.US,
                "uruguay" => CountryCode.UY,
                "uzbekistan" => CountryCode.UZ,
                "vanuatu" => CountryCode.VU,
                "venezuela" => CountryCode.VE,
                "vietnam" => CountryCode.VN,
                "british virgin islands" => CountryCode.VG,
                "united states virgin islands" => CountryCode.VI,
                "us virgin islands" => CountryCode.VI,
                "wallis and futuna" => CountryCode.WF,
                "western sahara" => CountryCode.EH,
                "yemen" => CountryCode.YE,
                "zambia" => CountryCode.ZM,
                "zimbabwe" => CountryCode.ZW,
                "åland" => CountryCode.AX,
                _ => throw new NotSupportedException($"Cannot find country {countryName}")
            };
        }
    }
}