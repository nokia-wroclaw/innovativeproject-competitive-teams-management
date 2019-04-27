import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import css from './file.css';
//import Footer from './components/Layout/Footer';
import Header from './components/Layout/Header';
import Clock from './components/Clock/Clock';
import Button from './components/Button/Button';
import Team from './components/Team/Team';




//gdyby sypa�o b��dami yarn add @babel/plugin-proposal-class-properties --dev /
// npm install @material-ui/core


//ReactDOM.render(<div>TEST </div>, document.getElementById("root"));



ReactDOM.render(<Header />, document.getElementById('root'));
ReactDOM.render(<Clock />, document.getElementById('root2'));
ReactDOM.render(<Button />, document.getElementById('root3'));
ReactDOM.render(<Team />, document.getElementById('root4'));
ReactDOM.render(<Footer />, document.getElementById('root5'));









