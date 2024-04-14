import { CoursesService } from './courses.service';
import { Component } from '@angular/core';
@Component({
    selector: 'courses', //<courses>
    template: `
        <h2>{{title}}</h2>
        <ul>
            <li *ngFor="let course of courses">
                {{course}}
            </li>
        </ul>`
        
})
export class CoursesComponent{
    title ="List of courses";
    /*getTitle(){
        return this.title;
    }*/
    courses;
    constructor(service: CoursesService){
        this.courses=service.getCourses()
    }
}