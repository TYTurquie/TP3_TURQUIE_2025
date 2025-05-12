public class Catalogo
{
    static public Dictionary<int, Album>? Albunes { get; private set; }
    public static void InicializarAlbum()
    { if (Albunes == null)
        {
            Albunes = new Dictionary<int, Album>();
        Albunes.Add(1, new Album("YHLQMDLG", "Bad Bunny", "Trap", "Tainy",
        new List<Canciones>
        {
            new Canciones("Si Veo a Tu Mamá"),
            new Canciones("La Difícil"),
            new Canciones("Pero Ya No"),
            new Canciones("La Santa"),
            new Canciones("Yo Perreo Sola"),
            new Canciones("Bichiyal"),
            new Canciones("Soliá"),
            new Canciones("La Zona"),
            new Canciones("Qué Malo"),
            new Canciones("Vete"),
            new Canciones("Ignorantes"),
            new Canciones("A Tu Merced"),
            new Canciones("Una Vez"),
            new Canciones("Safaera"),
            new Canciones("25/8"),
            new Canciones("Está Cabrón Ser Yo"),
            new Canciones("Puesto Pa’ Guerrial"),
            new Canciones("P FKN R"),
            new Canciones("Hablamos Mañana"),
            new Canciones("<3"),


    },"YHLQMDLG.JPG"));
        Albunes.Add(2, new Album("Sauce Boyz 2", "Eladio Carrión", "Trap", "Hydro",
        new List<Canciones>
        {
            new Canciones("Par de Tenis"),
            new Canciones("Claro Cristal"),
            new Canciones("No Te Deseo el Mal"),
            new Canciones("Flores en Anónimo"),
            new Canciones("Fuego"),
            new Canciones("Miradas Raras"),
            new Canciones("Me Gustas Natural"),
            new Canciones("Quienes Son Ustedes"),
            new Canciones("Alejarme de Ti"),
            new Canciones("Cuarentena"),
            new Canciones("Socio"),
            new Canciones("Jóvenes Millonarios"),
            new Canciones("Sauce Boy Freestyle 5"),
            new Canciones("Touch Your Body"),
            new Canciones("Tata"),
            new Canciones("Tata (Remix)"),
            new Canciones("Guerrero"),
            new Canciones("Redbull"),
            new Canciones("Hielo"),
            new Canciones("Te Dijeron"),
            new Canciones("Problema"),
            new Canciones("No Me Llamas")
    },"SauceBoyz2.jpg"));
        Albunes.Add(3, new Album("Desde el Fin del Mundo", "Duki", "Trap", "Asan",
        new List<Canciones>
    {
        new Canciones("Muero de Fiesta Este Finde"),
        new Canciones("Pintao"),
        new Canciones("Ticket"),
        new Canciones("Malbec"),
        new Canciones("Chico Estrella"),
        new Canciones("I Don't Know"),
        new Canciones("Valentino"),
        new Canciones("Sol"),
        new Canciones("Luna"),
        new Canciones("Sudor y Trabajo"),
        new Canciones("Cascada"),
        new Canciones("Yin Yan"),
        new Canciones("Muriéndome"),
        new Canciones("Cuanto"),
        new Canciones("Rockstar 2.0"),
        new Canciones("Muriéndome (Remix)"),
        new Canciones("Goteo (Remix)"),
        new Canciones("Muero de Fiesta Este Finde (Remix)")
    },"DesdeElFinDelMundo.jpg"));
    Albunes.Add(4, new Album("Trapicheo", "KHEA", "Trap", "Asan",
    new List<Canciones>
    {
        new Canciones("Trapicheo"),
        new Canciones("Creo Que ft. Asan"),
        new Canciones("Mamacita"),
        new Canciones("Algo Aparte"),
        new Canciones("Blunt"),
        new Canciones("Valgo ft. Midel"),
        new Canciones("Miti y Miti ft. Pablito Chill-E"),
        new Canciones("Nuevo ft. Seven Kayne"),
        new Canciones("Is It Por Mi"),
        new Canciones("Gelato 44 ft. Duki")
    },"Trapicheo.jpg"));
        Albunes.Add(5, new Album("El Último Tour del Mundo", "Bad Bunny", "Trap", "MAG",
        new List<Canciones>
    {
        new Canciones("El Mundo Es Mío"),
        new Canciones("Yo Visto Así"),
        new Canciones("Te Deseo Lo Mejor"),
        new Canciones("Haciendo Que Me Amas"),
        new Canciones("Te Mudaste"),
        new Canciones("Booker T"),
        new Canciones("Maldita Pobreza"),
        new Canciones("La Droga"),
        new Canciones("Antes Que Se Acabe"),
        new Canciones("Trellas"),
        new Canciones("La Noche de Anoche"),
        new Canciones("DÁKITI"),
        new Canciones("Pa' Romperla"),
        new Canciones("Bye Me Fui"),
        new Canciones("Pa' Que Me Invitan"),
        new Canciones("El Mundo Es Mío (Remix)")
    },"ElUltimoTour.jpg"));
        Albunes.Add(6, new Album("x100PRE", "Bad Bunny", "Trap", "MAG",
        new List<Canciones>
    {
        new Canciones("Ni Bien Ni Mal"),
        new Canciones("Vete"),
        new Canciones("Si Estuviésemos Juntos"),
        new Canciones("200 MPH"),
        new Canciones("Pa' Romperla"),
        new Canciones("La Rompe Corazones"),
        new Canciones("Esclava"),
        new Canciones("Qué Pretendes"),
        new Canciones("Por Siempre"),
        new Canciones("Caro"),
        new Canciones("Mia"),
        new Canciones("Te Gusta"),
        new Canciones("Estamos Bien"),
        new Canciones("La Canción"),
        new Canciones("Pendejo"),
        new Canciones("Hoy Cobré"),
        new Canciones("¿Quién Tú Eres?"),
        new Canciones("Diles Que No"),
        new Canciones("No Me Conoces"),
        new Canciones("Tú No Metes Cabra"),
        new Canciones("X100PRE")
    },"x100PRE.jpg"));
        Albunes.Add(7, new Album("Nadie sabe lo que va a pasar mañana", "Bad Bunny", "Trap", "Héctor Torres",
        new List<Canciones>
    {
        new Canciones("NADIE SABE"),
        new Canciones("MONACO"),
        new Canciones("FINA"),
        new Canciones("HIBIKI"),
        new Canciones("MR. OCTOBER"),
        new Canciones("SEDA"),
        new Canciones("UN PREVIEW"),
        new Canciones("GRACIAS POR NADA"),
        new Canciones("VOU 787"),
        new Canciones("NO ME QUIERO CASAR"),
        new Canciones("BATICANO"),
        new Canciones("WHERE SHE GOES"),
        new Canciones("UN X100TO"),
        new Canciones("EUROPA :("),
        new Canciones("ACHO PR"),
        new Canciones("SUEÑO"),
        new Canciones("NO TE VAS A ACORDAR"),
        new Canciones("LA NOCHE DE ANOCHE"),
        new Canciones("DEBÍ TIRAR MÁS FOTOS"),
        new Canciones("PA' QUE RETOZEN"),
        new Canciones("PA' QUE ME INVITAN")
    },"NadieSabeLoQueVaAPasarMañana.jpg"));
     Albunes.Add(8, new Album("Las Que No Iban A Salir", "Bad Bunny", "Trap", "La Paciencia",
        new List<Canciones>
    {
        new Canciones("Si Ella Sale"),
        new Canciones("Más De Una Cita"),
        new Canciones("Bye Me Fui"),
        new Canciones("Canción Con Yandel"),
        new Canciones("Pa' Romperla"),
        new Canciones("Bad Con Nicky"),
        new Canciones("Bendiciones"),
        new Canciones("Cómo Se Siente (Remix)"),
        new Canciones("Ronca Freestyle"),
        new Canciones("En Casita")
    },"LasQueNoIbanASalir.jpg"));
        Albunes.Add(9, new Album("Debí tirar más fotos", "Bad Bunny", "Reggaetón", "Tainy",
        new List<Canciones>
    {
        new Canciones("Eoo"),
        new Canciones("Dile Que Tú Me Quieres"),
        new Canciones("No Me Llamas"),
        new Canciones("Baila Conmigo"),
        new Canciones("Te Extraño"),
        new Canciones("Sin Ti"),
        new Canciones("Vuelve"),
        new Canciones("Amor Eterno"),
        new Canciones("Dímelo"),
        new Canciones("Quiero Verte"),
        new Canciones("Por Siempre"),
        new Canciones("Mami"),
        new Canciones("Pa' La Calle"),
        new Canciones("Te Vas"),
        new Canciones("No Es Lo Mismo"),
        new Canciones("Hasta El Final")
    },"DebiTirarMasFotos.jpg"));
    Albunes.Add(10, new Album("AMERÍ", "Bad Bunny", "Trap", "MAG",
    new List<Canciones>
    {
        new Canciones("Intro"),
        new Canciones("Amor de Verano"),
        new Canciones("Baila Conmigo"),
        new Canciones("Te Quiero Ver"),
        new Canciones("Sin Ti"),
        new Canciones("No Me Llamas"),
        new Canciones("Dímelo"),
        new Canciones("Quiero Verte"),
        new Canciones("Por Siempre"),
        new Canciones("Mami"),
        new Canciones("Pa' La Calle"),
        new Canciones("Te Vas")
    },"Ameri.jpg"));
    } 
    }
}