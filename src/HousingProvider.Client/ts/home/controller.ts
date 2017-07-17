import { home as h } from './module'
import './service';

class Request{
  sender: string;
  address: string;
  description: string;
  dateCreated: number;
  urgent: boolean;

  constructor(){
    this.sender = "no one";
    this.address = "404 nobody ln, apt. 404, nowhere, N/A, 50404";
    this.description = "";
    this.dateCreated = Date.now();
    this.urgent = true;
  }
}

h.controller('homeController', ['$scope', 'homeFactory', function($scope, homeFactory){
  
}])