import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HeaderMainPageComponent } from './header-main-page.component';

describe('HeaderMainPageComponent', () => {
  let component: HeaderMainPageComponent;
  let fixture: ComponentFixture<HeaderMainPageComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [HeaderMainPageComponent]
    });
    fixture = TestBed.createComponent(HeaderMainPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
