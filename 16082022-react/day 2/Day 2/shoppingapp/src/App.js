import logo from './logo.svg';
import './App.css';
import { Component } from 'react';
import Products from './Components/products';

class App extends Component
{
  appName = "Shopping APP";
  appDeveloper = "Nikhiil";


  render(){
    return(<div>
      <h1>{ this.appName } </h1>
      <p> Developed By {  this.appDeveloper } </p>

      <Products></Products>
    </div>)
  }


}

export default App;
