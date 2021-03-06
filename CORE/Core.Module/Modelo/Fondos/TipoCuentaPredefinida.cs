using System.ComponentModel;
using DevExpress.Xpo;

namespace FDIT.Core.Fondos
{
  [Persistent( @"fondos.TipoCuentaPredefinida" )]
  [DefaultProperty("Nombre")]
  [System.ComponentModel.DisplayName( "Tipos de Cuentas Predefinidas" )]
  public class TipoCuentaPredefinida : BasicObject
  {
    private string fNombre;

    public TipoCuentaPredefinida( Session session ) : base( session )
    {
    }

    public string Nombre
    {
      get { return fNombre; }
      set { SetPropertyValue( "Nombre", ref fNombre, value ); }
    }

    public override void AfterConstruction( )
    {
      base.AfterConstruction( );
    }
  }
}