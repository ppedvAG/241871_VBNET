Public Class HalloBinding

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


        TextBox2.DataBindings.Add("Text", TextBox1, "Text", True, DataSourceUpdateMode.OnPropertyChanged)
        TextBox2.DataBindings.Add("BackColor", TextBox1, "Text", True, DataSourceUpdateMode.OnPropertyChanged)

    End Sub
End Class