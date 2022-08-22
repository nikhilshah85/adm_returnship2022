import logo from './logo.svg';
import './App.css';
import { Component } from 'react';
import Project from './Components/Project';
import Products from './Components/Products';

class App extends Component
{

  
constructor(props){ 

  super(props);
  this.state ={
    appName:'Shopping APP - React',
    developerName:'Nikhil Shah',
    teamSize:30,
    isLive:false,
    teamMembers:['Nikhil','Akshay','Karan','Rahul','Sumit'],

    totalProduct:150,

    greet:function(){
      alert('Hello and Welcome to React State and Props');
    }   
  }
}

  render(){
    return(<div>
      <h1> { this.state.appName } </h1>

      <button onClick={this.state.greet}>Greet</button>

      <Project devaloper={this.state.developerName}
              totalMembers = {this.state.teamSize}
              team = {this.state.teamMembers}
              greetings={this.state.greet}></Project>

            <Products totalProductsForSale={this.state.totalProduct}
                      greetings={this.state.greet}></Products>
      
    </div>)

  }
}

export default App;
