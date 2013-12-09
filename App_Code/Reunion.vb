Imports System.ServiceModel
Imports System.ServiceModel.Activation
Imports System.ServiceModel.Web

<ServiceContract(Namespace:="")>
<AspNetCompatibilityRequirements(RequirementsMode:=AspNetCompatibilityRequirementsMode.Allowed)>
Public Class Reunion

    ' Pour utiliser HTTP GET, ajoutez l'attribut <WebGet()>. (ResponseFormat par défaut=WebMessageFormat.Json)
    ' Pour créer une opération qui renvoie du code XML,
    '     ajoutez <WebGet(ResponseFormat:=WebMessageFormat.Xml)>,
    '     et incluez la ligne suivante dans le corps de l'opération :
    '         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml"
    <OperationContract()>
    Public Sub DoWork()
        ' Ajoutez votre implémentation d'opération ici
    End Sub

    ' Ajoutez des opérations supplémentaires ici et marquez-les avec <OperationContract()>

End Class
