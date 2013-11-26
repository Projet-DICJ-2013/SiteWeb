Imports System.ServiceModel
Imports System.ServiceModel.Activation
Imports System.ServiceModel.Web

<ServiceContract(Namespace:="")>
<AspNetCompatibilityRequirements(RequirementsMode:=AspNetCompatibilityRequirementsMode.Allowed)>
Public Class Service_Reunion

    Private Modele As PresenceModel
    ' Pour utiliser HTTP GET, ajoutez l'attribut <WebGet()>. (ResponseFormat par défaut=WebMessageFormat.Json)
    ' Pour créer une opération qui renvoie du code XML,
    '     ajoutez <WebGet(ResponseFormat:=WebMessageFormat.Xml)>,
    '     et incluez la ligne suivante dans le corps de l'opération :
    '         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml"
    <OperationContract()>
    Public Sub DoWork()
        ' Ajoutez votre implémentation d'opération ici
    End Sub

    Public Function GetOrd() As List(Of tblOrdreDuJour)

        Dim MonOrd = (From ord In Modele.tblOrdreDuJour
                    Select ord).ToList

        Return MonOrd

    End Function

    ' Ajoutez des opérations supplémentaires ici et marquez-les avec <OperationContract()>

End Class
