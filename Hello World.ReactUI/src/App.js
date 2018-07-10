import React, { Component } from 'react';
import logo1 from './logo1.jpg';
import './App.css';
import { ContactUs } from './contact-us/ContactUs';
import { TitlePage } from './title-page/TitlePage';


class App extends Component {
  render() {
    return (
      <div className="App">
        <header className="App-header">
          <img src={logo1} className="App-logo" alt="logo1" />
          <TitlePage />
        </header>
        <br/>
        <ContactUs/>
      </div>
    );
  }
}

export default App;
