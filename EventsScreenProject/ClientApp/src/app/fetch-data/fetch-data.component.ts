import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public events: any[];
  public interval = 1000*60*60;
  

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {

    this.GetEvents(http, baseUrl);
    this.Reload(http, baseUrl);
  }


  GetEvents(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    var Inject = function (url: string) { throw new Error("Not implemented"); };
    http.get<any[]>(baseUrl + 'api/events').subscribe(result => {
      this.events = result;
      console.log(this.events);
    }, error => console.error(error));
  }

 
  Reload(http: HttpClient, @Inject('BASE_URL') baseUrl: string): void {
    setInterval(() => {
      this.GetEvents(http, baseUrl);
    }, this.interval);
  }



}


interface WeatherForecast {
  dateFormatted: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
