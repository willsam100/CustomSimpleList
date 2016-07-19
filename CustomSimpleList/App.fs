namespace CustomSimpleList

open System
open Xamarin.Forms
open Xamarin.Forms.Xaml

type Employee = {
    title:string
    subtitle:string
}

type Item = {
    category: string
    amount: string
}


type CustomCellPage() =
    inherit ContentPage() 

    do base.LoadFromXaml(typeof<CustomCellPage>) |> ignore
    let data = [
    //                {title = "Wind in the willows"; subtitle="some old bood"}; 
    //                {title = "Movie"; subtitle="subtitle"}
    //                {title = "I'm on a boat"; subtitle="with Tom Hanks"}
    //                {title = "Tv"; subtitle="a show"}
    //            ]

        {category = "Water"; amount="10"}
        {category = "Food"; amount="200"}]
    let movieList = base.FindByName<ListView>("listView")
    do movieList.ItemsSource <- ((data |> List.toSeq) :> Collections.IEnumerable)


type App() = 
    inherit Application(MainPage = CustomCellPage())

