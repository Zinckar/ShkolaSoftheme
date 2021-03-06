import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-article-details',
  templateUrl: './article-details.component.html',
  styleUrls: ['./article-details.component.css']
})
export class ArticleDetailsComponent implements OnInit 
{
    constructor() { }
    article: any[] = 
    [{
      id: '1',
      title: 'Як знiмали рекламу Apple в Украiнi',
      shortDescription: 'Режисер клiпу Rolling in the Deep, скейтер з Iспанii та оператор на роликах з Пiвденноi Африки'
    }]

    heading ="";
    isClicked = false;
    titleColor;
    changeColor(): void 
    {
      this.isClicked = !this.isClicked;
      if(this.isClicked) this.titleColor = 'gray';
    }
  
    ngOnInit() 
    {
    }
  
  }