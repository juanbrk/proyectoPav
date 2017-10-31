Imports Hund_Tier

Public Class PublicacionService
    Dim publiDao As New PublicacionDAO
    Public Sub New()
        publiDao = New PublicacionDAO()
    End Sub

    Public Function agregarAnimal(unAnimal As Animal) As Integer
        Return publiDao.addAnimal(unAnimal)
    End Function

    'Funcion que agrega publicacion de adopcion. Puede que sea solo agregarPublicacion y que haga el chequeo del 
    'tipo de publicacion en el DAO
    Public Function agregarPublicacionAdopcion(unaPublicacion As Publicacion) As Integer
        Return publiDao.addPublicacionAdopcion(unaPublicacion)
    End Function

    ' Funcion que nos permite pedirle a la DAO que consulte a la BD segun los parametros pasados
    ' Devuelve una lista de publicaciones
    ' La lista devuelta servirá para llenar la dgv
    Public Function consultarPublicacionesConFiltro(params As Object()) As List(Of Publicacion)
        Return publiDao.getPublicacionConFiltros(params)
    End Function

    Public Function publicarAdopcionTransaccion(unaPubli As Publicacion) As Integer
        Return publiDao.publicarAdopcionConTransaccion(unaPubli)
    End Function

    Friend Function generarIdBusqueda() As Integer
        Return BDHelper.getDBHelper.generarId("Busquedas")
    End Function

    Friend Function agregarBusqueda(unaBusqueda As Busqueda) As Integer
        Return publiDao.cargarnuevaBusqueda(unaBusqueda)
    End Function

    Friend Function generarReporteAnimalXTipoPublicacion(reformatedDesde As String, reformattedHasta As String) As Object
        Return publiDao.generarReporteAnimalXTipoPublicacion(reformatedDesde, reformattedHasta)
    End Function

    Friend Function generarReporteUsuariosPublicaciones(reformatedDesde As String, reformattedHasta As String) As Object
        Return publiDao.generarReportePublicacionXUsuario(reformatedDesde, reformattedHasta)
    End Function

    Friend Function generarReporteRazasGato(reformatedDesde As String, reformattedHasta As String) As Object
        Return publiDao.generarReporteRazasGato(reformatedDesde, reformattedHasta)
    End Function

    Friend Function generarReporteRazasPerro(reformatedDesde As String, reformattedHasta As String) As Object
        Return publiDao.generarReporteRazasPerro(reformatedDesde, reformattedHasta)
    End Function

    Friend Function generarReporteTipoPublicacion(reformatedDesde As String, reformattedHasta As String) As Object
        Return publiDao.getReportesTipoPublicacion(reformatedDesde, reformattedHasta)
    End Function

    Friend Function generarReporteTipoAnimal(reformatedDesde As String, reformattedHasta As String) As Object
        Return publiDao.getReportesTipoAnimal(reformatedDesde, reformattedHasta)
    End Function

End Class
