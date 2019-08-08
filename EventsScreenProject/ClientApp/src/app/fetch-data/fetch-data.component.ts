import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})

export class FetchDataComponent {
  public events: any[];
  reloadTime = 1000 * 60 * 60;
  swappingTime: number = 1000 * 5;
  selectedEventIndex = 0;
  selectedEvent: any;
  selectedBackground: any;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.GetEvents(http, baseUrl);
    this.GetSwappingTime(http, baseUrl);
    
    this.Reload(http, baseUrl);
  }


  GetEvents(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<any[]>(baseUrl + 'api/events/GetTodayEvents').subscribe(result => {
      this.events = result;
      
      if (this.events.length == 0) {
        this.GetDefaultImg(http, baseUrl);
        
      } else  {
        this.selectedEvent = this.events[this.selectedEventIndex];
        this.selectedBackground = this.selectedEvent.background;

        if (this.events.length > 1) {
          this.Swap();
        }

      }

      }, error => console.error(error));
  }

  GetSwappingTime(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    var Inject = function (url: string) { throw new Error("Not implemented"); };
   
    http.get<number>(baseUrl + 'api/AppSetting/SwappingTime').subscribe(result => {
      this.swappingTime = result;
    }, error => console.error(error));
  }
  
  GetDefaultImg(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    var url = baseUrl + 'api/AppSetting/DefaultImg';
    http.get(url, {responseType: 'text'}).subscribe(result => {
      this.selectedBackground = result;
      
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
