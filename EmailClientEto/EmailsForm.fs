namespace EmailClientEto

open Eto.Forms
open Eto.Drawing

type EmailForm() as this =
    inherit Form()

    do
        this.Title <- "Emails!"
        this.MinimumSize <- new Size(400, 400)
        this.Padding <- new Padding(10)

        let layout = new StackLayout()
        layout.Items.Add(new StackLayoutItem(new Label(Text = "Here are your emails")))

        this.Content <- layout

// let clickMe = new Command(MenuText = "Click Me!", ToolBarText = "Click Me!")
// clickMe.Executed.Add(fun e -> printf "Clicked!")

// let quitCommand = new Command(MenuText = "Quit")
// quitCommand.Shortcut <- Application.Instance.CommonModifier ||| Keys.Q
// quitCommand.Executed.Add(fun e -> Application.Instance.Quit())

// let aboutCommand = new Command(MenuText = "About...")

// aboutCommand.Executed.Add (fun e ->
//     let dlg = new AboutDialog()
//     dlg.ShowDialog(this) |> ignore)

// this.Menu <- new MenuBar()
// let fileItem = new ButtonMenuItem(Text = "&File")
// fileItem.Items.Add(clickMe) |> ignore
// this.Menu.Items.Add(fileItem)

// this.Menu.ApplicationItems.Add(new ButtonMenuItem(Text = "&Preferences..."))
// this.Menu.QuitItem <- quitCommand.CreateMenuItem()
// this.Menu.AboutItem <- aboutCommand.CreateMenuItem()

// this.ToolBar <- new ToolBar()
// this.ToolBar.Items.Add(clickMe)
