using System;
using System.Linq;

class Turbina
{
    private int numTurbinas = 0;
    public Turbina(int n) 
    {
        numTurbinas = n;
    }
    public override string ToString()
    {
        return numTurbinas + " Turbina/s";
    }
}

class Helice
{
    private int numHelices = 0;
    public Helice(int n)
    {
        numHelices = n;
    }
    public override string ToString()
    {
        return numHelices + " hélice/s";
}

}

class TrendeAterrizaje
{
    private int numNeumaticos = 0;
    private int numAmortiguadores = 0;
    private bool fijoRetractil = false;
    public TrendeAterrizaje(int a, int b, bool c)
    {
        numNeumaticos = a;
        numAmortiguadores = b;
        fijoRetractil = c;
    }
    public override string ToString()
    {
        string mensaje = "Tren de Aterrizaje compuesto por: ";
        if (fijoRetractil)
        {
            mensaje += " con Retractil fijo, ";
        }
        mensaje += numNeumaticos + " neumáticos, " + numAmortiguadores + " amoriguadores ";
        return mensaje;
    }
}

class Cubierta
{
    private bool cabinaTripulacion = false;
    private bool cabinaVuelo = false;
    private bool sistemaEmergencia = false;
    private int numTanquesCombustible = 0;
    private int numPuertasSalidas = 0;
    public Cubierta(bool pCabinaTripulacion, bool pCabinaVuelo, bool pSistemaEmergencia, int pTanquesCombustible, int pPuertasSalida)
    {
        cabinaTripulacion = pCabinaTripulacion;
        cabinaVuelo = pCabinaVuelo;
        sistemaEmergencia = pSistemaEmergencia;
        numTanquesCombustible = pTanquesCombustible;
        numPuertasSalidas = pPuertasSalida;
    }

    public override string ToString()
    {
        string mensaje = "Cubierta compuesta de: ";
        if (cabinaVuelo)
        {
            mensaje += " Cubierta de Vuelo, ";
        }
        if (cabinaTripulacion)
        {
            mensaje += " Cubierta de Tripulación, ";
        }
        if (sistemaEmergencia)
        {
            mensaje += " Sistema de Emergencia, ";
        }
        mensaje += numTanquesCombustible + " Tanques de Combustible, ";
        mensaje += numPuertasSalidas + " Puertas de Salida.";
        return mensaje;
    }
}

class Alas
{
   private int numAlasFrente = 0;
   private int numAlasCola = 0;
   public Alas(int mAlasFrente, int nAlasCola) 
   {
       numAlasFrente = mAlasFrente;
       numAlasCola = nAlasCola;
   }

    public override string ToString()
    {
        return "Alas Frontales: " + numAlasFrente + " Alas Posteriore: " + numAlasCola;
    }

}

class Aeroplano
{
    private Helice helice;
    private TrendeAterrizaje trenAterrizaje;
    private Alas alas;
    private Cubierta cubierta;

    public Aeroplano(Helice phelice, TrendeAterrizaje pTrenAterrizaje, Alas pAlas, Cubierta pCubierta)
    {
         helice = phelice;
         trenAterrizaje = pTrenAterrizaje;
         alas = pAlas;
         cubierta = pCubierta;
    }
    public override string ToString()
    {
        string mensaje = "Aeroplano compuesto por: ";
        mensaje += helice.ToString();
        mensaje += alas.ToString();
        mensaje += trenAterrizaje.ToString();
        mensaje += cubierta.ToString();
        return mensaje;

    }
}
