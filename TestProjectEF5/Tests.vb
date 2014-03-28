﻿Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports alatas.GeoJSON4EntityFramework5

<TestClass()> Public Class Tests
    Dim countries As New List(Of country)

    Private Class country
        Sub New(_code As String, _name As String, _geometry As String)
            MyBase.New()
            Code = _code
            Name = _name
            Geometry = _geometry
        End Sub

        Property Code As String
        Property Name As String
        Property Geometry As String
    End Class

    <TestInitialize()>
    Sub Init()
        countries.Add(New country("TR", "Turkey", "MULTIPOLYGON (((26.763891220092773 40.659988403320312, 26.211593627929688 40.322147369384766, 26.164405822753906 40.051971435546875, 27.505342483520508 40.981307983398438, 29.036247253417969 41.0545768737793, 29.088882446289062 41.246242523193359, 28.090549468994141 41.631385803222656, 28.013053894042969 41.982215881347656, 27.569580078125 41.909263610839844, 27.070270538330078 42.089988708496094, 26.361095428466797 41.711051940917969, 26.635759353637695 41.364715576171875, 26.324996948242188 41.234710693359375, 26.36041259765625 40.953880310058594, 26.044719696044922 40.735824584960938, 26.118608474731445 40.595127105712891, 26.763891220092773 40.659988403320312)), ((44.787338256835938 37.149711608886719, 44.617767333984375 37.717975616455078, 44.223968505859375 37.899150848388672, 44.482517242431641 38.341300964355469, 44.305259704589844 38.400535583496094, 44.034954071044922 39.377445220947266, 44.401100158691406 39.4165153503418, 44.608463287353516 39.779155731201172, 44.813041687011719 39.630813598632812, 44.816375732421875 39.645820617675781, 44.778861999511719 39.706382751464844, 44.351661682128906 40.022220611572266, 43.66839599609375 40.103179931640625, 43.583053588867188 40.45111083984375, 43.750408172607422 40.744998931884766, 43.460769653320312 41.112960815429688, 42.831020355224609 41.582416534423828, 42.472213745117188 41.433326721191406, 41.531558990478516 41.523876190185547, 40.149993896484375 40.920272827148438, 39.414226531982422 41.106731414794922, 38.3558235168457 40.910270690917969, 36.80999755859375 41.355552673339844, 36.4315185546875 41.2420768737793, 36.056102752685547 41.688743591308594, 35.286651611328125 41.713050842285156, 35.006385803222656 42.086097717285156, 34.715545654296875 41.942489624023438, 33.338600158691406 42.019851684570312, 32.277496337890625 41.719436645507812, 31.233469009399414 41.089298248291016, 29.159999847412109 41.224575042724609, 29.129440307617188 40.914443969726562, 29.9339542388916 40.722209930419922, 28.776729583740234 40.527076721191406, 29.055761337280273 40.366798400878906, 27.953193664550781 40.35693359375, 28.020133972167969 40.487705230712891, 27.754858016967773 40.529720306396484, 27.877841949462891 40.375858306884766, 27.511661529541016 40.3055534362793, 27.118606567382812 40.452766418457031, 26.704301834106445 40.378879547119141, 26.157497406005859 39.946659088134766, 26.109994888305664 39.4576301574707, 26.951801300048828 39.550827026367188, 26.644721984863281 39.263053894042969, 27.062980651855469 38.873184204101562, 26.733745574951172 38.641937255859375, 27.156452178955078 38.452804565429688, 26.691801071166992 38.310855865478516, 26.398330688476562 38.666938781738281, 26.509857177734375 38.425479888916016, 26.275829315185547 38.264434814453125, 27.268329620361328 37.953598022460938, 27.194925308227539 37.352348327636719, 27.59527587890625 37.232490539550781, 27.2549991607666 36.964996337890625, 28.324787139892578 37.038185119628906, 27.374719619750977 36.684024810791016, 28.120136260986328 36.797077178955078, 27.98388671875 36.552772521972656, 28.456386566162109 36.880828857421875, 29.052497863769531 36.681106567382812, 29.148050308227539 36.34832763671875, 29.677215576171875 36.118331909179688, 30.208608627319336 36.303874969482422, 30.404857635498047 36.204921722412109, 30.616525650024414 36.843605041503906, 31.046661376953125 36.849151611328125, 32.064712524414062 36.516387939453125, 32.771659851074219 36.028884887695312, 33.988601684570312 36.27777099609375, 34.659431457519531 36.805274963378906, 35.347072601318359 36.544990539550781, 36.011203765869141 36.923191070556641, 36.217281341552734 36.654781341552734, 35.785545349121094 36.314846038818359, 35.922439575195312 35.926994323730469, 36.1684684753418 35.819717407226562, 36.392219543457031 36.213325500488281, 36.6831169128418 36.232734680175781, 36.549575805664062 36.487770080566406, 36.659942626953125 36.833709716796875, 37.373813629150391 36.655338287353516, 38.2433967590332 36.91387939453125, 39.221523284912109 36.665340423583984, 40.770820617675781 37.118049621582031, 41.548187255859375 37.085273742675781, 42.180831909179688 37.290542602539062, 42.355613708496094 37.106925964355469, 42.786800384521484 37.383674621582031, 44.118881225585938 37.3156852722168, 44.319160461425781 36.971237182617188, 44.787338256835938 37.149711608886719)), ((27.601661682128906 40.571937561035156, 27.60930061340332 40.572769165039062, 27.706943511962891 40.649993896484375, 27.545967102050781 40.654991149902344, 27.601661682128906 40.571937561035156)), ((25.731666564941406 40.093040466308594, 25.958053588867188 40.121101379394531, 25.940549850463867 40.239990234375, 25.688888549804688 40.164985656738281, 25.731666564941406 40.093040466308594)))"))
        countries.Add(New country("GR", "Greece", "MULTIPOLYGON (((21.083049774169922 39.056663513183594, 21.085136413574219 38.8640251159668, 20.73277473449707 38.804439544677734, 21.164165496826172 38.300064086914062, 22.408609390258789 38.446037292480469, 23.224649429321289 38.153396606445312, 22.862775802612305 37.939579010009766, 21.853609085083008 38.339580535888672, 21.384441375732422 38.211387634277344, 21.110971450805664 37.885688781738281, 21.64971923828125 37.441940307617188, 21.7036075592041 36.816665649414062, 21.87513542175293 36.723537445068359, 22.120830535888672 37.026664733886719, 22.488887786865234 36.3861083984375, 22.632497787475586 36.803607940673828, 23.201454162597656 36.440200805664062, 22.725551605224609 37.563400268554688, 23.179719924926758 37.290412902832031, 23.517082214355469 37.432704925537109, 22.991804122924805 37.882358551025391, 23.511663436889648 38.039302825927734, 24.033956527709961 37.6528434753418, 24.074026107788086 38.194995880126953, 22.52385139465332 38.866069793701172, 23.072776794433594 39.036941528320312, 22.8236083984375 39.21221923828125, 22.940830230712891 39.359367370605469, 23.221525192260742 39.182289123535156, 23.054859161376953 39.0979118347168, 23.343677520751953 39.181800842285156, 22.594997406005859 40.012214660644531, 22.585206985473633 40.464996337890625, 22.944927215576172 40.626522064208984, 22.899440765380859 40.396659851074219, 23.718471527099609 39.913887023925781, 23.353610992431641 40.245277404785156, 23.671108245849609 40.218330383300781, 23.932220458984375 39.94305419921875, 23.990970611572266 40.112495422363281, 23.729721069335938 40.351249694824219, 24.394094467163086 40.148017883300781, 23.88298225402832 40.400272369384766, 23.722011566162109 40.744647979736328, 25.141803741455078 41.010337829589844, 26.044719696044922 40.735824584960938, 26.36041259765625 40.953880310058594, 26.324996948242188 41.234710693359375, 26.635759353637695 41.364715576171875, 26.361095428466797 41.711051940917969, 26.07763671875 41.714298248291016, 26.139995574951172 41.354713439941406, 25.282358169555664 41.243049621582031, 24.25819206237793 41.569580078125, 22.935604095458984 41.342124938964844, 22.737741470336914 41.156108856201172, 20.983489990234375 40.855888366699219, 21.042079925537109 40.56402587890625, 20.667079925537109 40.096244812011719, 20.315414428710938 39.991802215576172, 20.413331985473633 39.820133209228516, 20.219997406005859 39.647357940673828, 20.010028839111328 39.691200256347656, 20.733331680297852 38.953395843505859, 20.820831298828125 39.113605499267578, 21.083049774169922 39.056663513183594)), ((24.643608093261719 40.570831298828125, 24.773330688476562 40.631660461425781, 24.643192291259766 40.797218322753906, 24.509441375732422 40.658050537109375, 24.643608093261719 40.570831298828125)), ((25.657218933105469 40.493049621582031, 25.494163513183594 40.496383666992188, 25.561941146850586 40.399574279785156, 25.657218933105469 40.493049621582031)), ((25.441665649414062 40.004714965820312, 25.047636032104492 39.986656188964844, 25.054439544677734 39.860549926757812, 25.355827331542969 39.786384582519531, 25.441665649414062 40.004714965820312)), ((19.854999542236328 39.818328857421875, 19.674581527709961 39.675968170166016, 20.111663818359375 39.363052368164062, 19.854999542236328 39.818328857421875)), ((26.419994354248047 39.325828552246094, 25.834856033325195 39.1800651550293, 26.615690231323242 39.013881683349609, 26.419994354248047 39.325828552246094)), ((23.724441528320312 39.071388244628906, 23.772775650024414 39.096523284912109, 23.594858169555664 39.204925537109375, 23.724441528320312 39.071388244628906)), ((24.049999237060547 38.365829467773438, 24.564163208007812 37.987220764160156, 24.561246871948242 38.144302368164062, 24.258260726928711 38.21728515625, 24.153888702392578 38.646659851074219, 23.591941833496094 38.764717102050781, 23.304443359375 39.037284851074219, 22.832843780517578 38.829124450683594, 23.198053359985352 38.8317985534668, 23.642219543457031 38.41888427734375, 24.049999237060547 38.365829467773438)), ((24.568885803222656 38.760826110839844, 24.681663513183594 38.802078247070312, 24.483192443847656 38.97735595703125, 24.568885803222656 38.760826110839844)), ((20.701385498046875 38.834716796875, 20.543191909790039 38.566104888916016, 20.722080230712891 38.627147674560547, 20.701385498046875 38.834716796875)), ((26.014720916748047 38.149436950683594, 26.159580230712891 38.542072296142578, 25.86583137512207 38.584999084472656, 26.014720916748047 38.149436950683594)), ((20.719718933105469 38.305274963378906, 20.707220077514648 38.443328857421875, 20.644721984863281 38.398048400878906, 20.719718933105469 38.305274963378906)), ((20.571109771728516 38.468048095703125, 20.342567443847656 38.177909851074219, 20.79347038269043 38.063259124755859, 20.571109771728516 38.468048095703125)), ((23.501110076904297 37.999160766601562, 23.489303588867188 38.000137329101562, 23.407358169555664 37.8942985534668, 23.546665191650391 37.930828094482422, 23.501110076904297 37.999160766601562)), ((24.960277557373047 37.685554504394531, 24.962776184082031 37.87249755859375, 24.694580078125 37.9626350402832, 24.960277557373047 37.685554504394531)), ((20.836109161376953 37.646385192871094, 20.998607635498047 37.713882446289062, 20.643329620361328 37.898330688476562, 20.836109161376953 37.646385192871094)), ((26.818050384521484 37.63665771484375, 27.066940307617188 37.727218627929688, 26.572219848632812 37.732353210449219, 26.818050384521484 37.63665771484375)), ((25.984161376953125 37.506942749023438, 26.323329925537109 37.634719848632812, 26.066246032714844 37.630966186523438, 25.984161376953125 37.506942749023438)), ((24.285274505615234 37.52471923828125, 24.298610687255859 37.526382446289062, 24.411388397216797 37.653190612792969, 24.299581527709961 37.656387329101562, 24.285274505615234 37.52471923828125)), ((25.053882598876953 37.675819396972656, 25.113887786865234 37.551101684570312, 25.248886108398438 37.613185882568359, 25.053882598876953 37.675819396972656)), ((24.440830230712891 37.470832824707031, 24.367080688476562 37.311244964599609, 24.482498168945312 37.395965576171875, 24.440830230712891 37.470832824707031)), ((25.452770233154297 36.918319702148438, 25.541872024536133 37.1976318359375, 25.341939926147461 37.073467254638672, 25.452770233154297 36.918319702148438)), ((25.191383361816406 36.973884582519531, 25.250274658203125 37.008323669433594, 25.223609924316406 37.140830993652344, 25.098814010620117 37.028533935546875, 25.191383361816406 36.973884582519531)), ((26.975551605224609 36.924430847167969, 27.047773361206055 36.945892333984375, 26.960548400878906 37.056106567382812, 26.935554504394531 36.932212829589844, 26.975551605224609 36.924430847167969)), ((26.971385955810547 36.672210693359375, 26.965831756591797 36.681663513183594, 27.279441833496094 36.834159851074219, 27.172775268554688 36.888046264648438, 26.92027473449707 36.711795806884766, 26.971385955810547 36.672210693359375)), ((25.357776641845703 36.644996643066406, 25.32611083984375 36.775825500488281, 25.263053894042969 36.764579772949219, 25.357776641845703 36.644996643066406)), ((24.330829620361328 36.649993896484375, 24.549442291259766 36.696109771728516, 24.350969314575195 36.746940612792969, 24.330829620361328 36.649993896484375)), ((26.466659545898438 36.576377868652344, 26.471103668212891 36.578330993652344, 26.263326644897461 36.589572906494141, 26.315271377563477 36.504852294921875, 26.466659545898438 36.576377868652344)), ((28.207221984863281 36.442489624023438, 27.804443359375 36.269439697265625, 27.73124885559082 35.913051605224609, 28.207221984863281 36.442489624023438)), ((22.956943511962891 36.377494812011719, 22.957010269165039 36.381317138671875, 22.929996490478516 36.178054809570312, 23.104303359985352 36.246246337890625, 22.956943511962891 36.377494812011719)), ((27.142219543457031 35.39971923828125, 27.159858703613281 35.448471069335938, 27.229721069335938 35.825412750244141, 27.161735534667969 35.725341796875, 27.142219543457031 35.39971923828125)), ((23.681941986083984 35.224441528320312, 25.016941070556641 34.930831909179688, 26.135831832885742 34.997287750244141, 26.301109313964844 35.283050537109375, 25.784027099609375 35.113887786865234, 25.765726089477539 35.329959869384766, 24.327081680297852 35.351383209228516, 24.176387786865234 35.588886260986328, 23.848539352416992 35.522983551025391, 23.741872787475586 35.686317443847656, 23.520553588867188 35.294998168945312, 23.681941986083984 35.224441528320312)))"))
    End Sub

    Private Function GetTestFeatureCollectionEF5() As FeatureCollection
        Dim fc As New FeatureCollection

        countries.ForEach(Sub(c)
                              Dim geom As Data.Spatial.DbGeometry = Data.Spatial.DbGeometry.FromText(c.Geometry)
                              Dim f = Feature.FromDbGeometry(geom)
                              f.ID = c.Code
                              f.Properties.Add("Name", c.Name)
                              f.Properties.Add("Area", geom.Area)
                              fc.Features.Add(f)
                          End Sub)
        Return fc
    End Function

    <TestMethod()> Public Sub TestMethodEF5_1()
        Dim fc = GetTestFeatureCollectionEF5()
        Dim json = GeoJsonSerializer.Serialize(Of FeatureCollection)(fc, True)
        Assert.IsNotNull(json)
        Console.Out.WriteLine("You can download spatial maps via http://www.naturalearthdata.com/, and after the process test your geojson via http://geojson.io or http://geojsonlint.com" & vbCrLf)
        Console.Out.WriteLine(json)
    End Sub

    <TestMethod()> Public Sub TestMethodOnlineEF5_1()
        Dim fc = GetTestFeatureCollectionEF5()
        Dim json = GeoJsonSerializer.Serialize(Of FeatureCollection)(fc, True)
        Assert.IsNotNull(json)
        Console.Out.WriteLine("You can download spatial maps via http://www.naturalearthdata.com/" & vbCrLf & vbCrLf)
        Console.Out.WriteLine(json)

        Dim buffer() As Byte = Text.Encoding.UTF8.GetBytes(json)
        Dim webReq As Net.HttpWebRequest = Net.WebRequest.Create("http://geojsonlint.com/validate")

        webReq.Method = "POST"
        webReq.ContentLength = buffer.Length
        webReq.ContentType = "application/x-www-form-urlencoded"

        Dim reqStream = webReq.GetRequestStream()
        reqStream.Write(buffer, 0, buffer.Length)
        reqStream.Close()

        Dim webRes = webReq.GetResponse
        Dim resStream = webRes.GetResponseStream
        Dim resReader As New IO.StreamReader(resStream)
        Dim resObj = Newtonsoft.Json.JsonConvert.DeserializeObject(Of GeoJSONLintResult)(resReader.ReadToEnd)

        Assert.AreEqual(resObj.status, "ok")
    End Sub

    Private Class GeoJSONLintResult
        Public Property status As String
        Public Property message As String
    End Class
End Class