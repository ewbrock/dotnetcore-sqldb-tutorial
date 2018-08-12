@page
@model WineTableMaint.Pages.Climates.CreateModel

@{
    ViewData["Title"] = "Create";
}

<h2>Create</h2>

<h4>Climate</h4>
<hr />
<div class="row">
    <div class="col-md-6">
        <form method="post">
            <div asp-validation-summary="ModelOnly" class="text-danger"></div>
            <div class="form-group">
                <label asp-for="Climate.Name" class="control-label"> Name: </label>
                <input asp-for="Climate.Name" class="form-control" />
                <span asp-validation-for="Climate.Name" class="text-danger"></span>
            </div>
            <div class="form-group">
                <label asp-for="Climate.Description" class="control-label"> Description: </label>
                <input asp-for="Climate.Description" class="form-control" />
                <span asp-validation-for="Climate.Description" class="text-danger"></span>
            </div>
            <div class="form-group">
                <label asp-for="Climate.Rain_in_Winter" class="control-label"> Rain in Winter: </label>
                <input type="radio" asp-for="Climate.Rain_in_Winter" value="High" /> High
                <input type="radio" asp-for="Climate.Rain_in_Winter" value="Moderate" checked /> Moderate
                <input type="radio" asp-for="Climate.Rain_in_Winter" value="Low" /> Low
                <span asp-validation-for="Climate.Rain_in_Winter" class="text-danger"></span>
            </div>
            <div class="form-group">
                <label asp-for="Climate.Rain_during_Growing_Season" class="control-label"> Rain During the Growing Season: </label>
                <input type="radio" asp-for="Climate.Rain_during_Growing_Season" value="High" /> High
                <input type="radio" asp-for="Climate.Rain_during_Growing_Season" value="Moderate" checked /> Moderate
                <input type="radio" asp-for="Climate.Rain_during_Growing_Season" value="Low" /> Low
                <span asp-validation-for="Climate.Rain_during_Growing_Season" class="text-danger"></span>
            </div>
            <div class="form-group">
                <label asp-for="Climate.Rain_during_Harvest" class="control-label"> Rain During the Harvest: </label>
                <input type="radio" asp-for="Climate.Rain_during_Harvest" value="High" /> High
                <input type="radio" asp-for="Climate.Rain_during_Harvest" value="Moderate" checked /> Moderate
                <input type="radio" asp-for="Climate.Rain_during_Harvest" value="Low" /> Low
                <span asp-validation-for="Climate.Rain_during_Harvest" class="text-danger"></span>
            </div>
            <div class="form-group">
                <label asp-for="Climate.Temp_in_Winter" class="control-label"> Temperature in Winter: </label>
                <input type="radio" asp-for="Climate.Temp_in_Winter" value="Cool" /> Cool
                <input type="radio" asp-for="Climate.Temp_in_Winter" value="Moderate" checked /> Moderate
                <input type="radio" asp-for="Climate.Temp_in_Winter" value="High" /> High
                <input type="radio" asp-for="Climate.Temp_in_Winter" value="Hot" /> Hot
                <span asp-validation-for="Climate.Temp_in_Winter" class="text-danger"></span>
            </div>
            <div class="form-group">
                <label asp-for="Climate.Temp_during_Growing_Season" class="control-label"> Temperature During the Growing Season: </label>
                <input type="radio" asp-for="Climate.Temp_during_Growing_Season" value="Cool" /> Cool
                <input type="radio" asp-for="Climate.Temp_during_Growing_Season" value="Moderate" checked /> Moderate
                <input type="radio" asp-for="Climate.Temp_during_Growing_Season" value="High" /> High
                <input type="radio" asp-for="Climate.Temp_during_Growing_Season" value="Hot" /> Hot
                <span asp-validation-for="Climate.Temp_during_Growing_Season" class="text-danger"></span>
            </div>
            <div class="form-group">
                <label asp-for="Climate.Temp_Continentality" class="control-label"> Temperature Continentality: </label>
                <input type="radio" asp-for="Climate.Temp_Continentality" value="High" /> High
                <input type="radio" asp-for="Climate.Temp_Continentality" value="Moderate" checked /> Moderate
                <input type="radio" asp-for="Climate.Temp_Continentality" value="Low" /> Low
                <span asp-validation-for="Climate.Temp_Continentality" class="text-danger"></span>
            </div>
            <div class="form-group">
                <label asp-for="Climate.Temp_Diurnal" class="control-label"> Temperature Diurnal: </label>
                <input type="radio" asp-for="Climate.Temp_Diurnal" value="High" /> High
                <input type="radio" asp-for="Climate.Temp_Diurnal" value="Moderate" checked /> Moderate
                <input type="radio" asp-for="Climate.Temp_Diurnal" value="Low" /> Low
                <span asp-validation-for="Climate.Temp_Diurnal" class="text-danger"></span>
            </div>
            <div class="form-group">
                <label asp-for="Climate.Vintage_Variation" class="control-label"> Vintage Variation: </label>
                <input type="radio" asp-for="Climate.Vintage_Variation" value="High" /> High
                <input type="radio" asp-for="Climate.Vintage_Variation" value="Moderate" checked /> Moderate
                <input type="radio" asp-for="Climate.Vintage_Variation" value="Low" /> Low
                <span asp-validation-for="Climate.Vintage_Variation" class="text-danger"></span>
            </div>
            <div class="form-group">
                <label asp-for="Climate.Proximity_to_Large_Bodies_of_Water" class="control-label"> Close to a Large Body of Water: </label>
                <input type="radio" asp-for="Climate.Proximity_to_Large_Bodies_of_Water" value="Yes" /> Yes
                <input type="radio" asp-for="Climate.Proximity_to_Large_Bodies_of_Water" value="No" checked /> No
                <span asp-validation-for="Climate.Proximity_to_Large_Bodies_of_Water" class="text-danger"></span>
            </div>
            <div class="form-group">
                <input type="submit" value="Create" class="btn btn-default" />
            </div>
        </form>
        </div>
    </div>

<div>
    <a asp-page="Index">Back to List</a>
</div>

@section Scripts {
    @{await Html.RenderPartialAsync("_ValidationScriptsPartial");}
}
