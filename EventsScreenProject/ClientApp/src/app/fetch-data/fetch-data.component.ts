import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})

export class FetchDataComponent {
  public events: any[];
  reloadTime = 1000 * 60 * 60;
  swappingTime = 1000 * 60;
  selectedEventIndex = 0;
  selectedEvent: any;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.GetEvents(http, baseUrl);
    this.Reload(http, baseUrl);
  }


  GetEvents(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    var Inject = function (url: string) { throw new Error("Not implemented"); };
    http.get<any[]>(baseUrl + 'api/events/GetTodayEvents').subscribe(result => {
      this.events = result;
      console.log(this.events);
     
      this.selectedEvent = this.events[this.selectedEventIndex];
      this.Swap();
      
    }, error => console.error(error));
  }

 
  Reload(http: HttpClient, @Inject('BASE_URL') baseUrl: string): void {
    setInterval(() => {
      this.GetEvents(http, baseUrl);
    }, this.reloadTime);
  }

  Swap(): void {
    setInterval(()=>{
      this.selectedEventIndex = (this.selectedEventIndex + 1) % this.events.length;
      this.selectedEvent = this.events[this.selectedEventIndex];
      
    }, this.swappingTime);
  }

 

}


interface WeatherForecast {
  dateFormatted: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
