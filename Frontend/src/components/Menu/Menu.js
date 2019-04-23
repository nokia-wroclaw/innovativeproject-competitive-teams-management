import React, { Component } from 'react';
import './Menu.css';


class Menu extends Component {
    render() {
        return (
            <nav className="menu">
            <h1 className="menu__logo">Nokia</h1>

            <div className="menu__right">
                <ul className="menu__list">
                    <li className="menu__list-item"><a className="menu__link menu__link--active" href="#">Home</a></li>
                    <li className="menu__list-item"><a className="menu__link" href="#">About</a></li>
                    <li className="menu__list-item"><a className="menu__link" href="#">Portfolio</a></li>
                    <li className="menu__list-item"><a className="menu__link" href="#">Contact</a></li>
                </ul>

                <button className="menu__search-button"></button>

                <form className="menu__search-form hide" method="POST">
                    <input className="menu__search-input" placeholder="Type and hit enter"/>
                </form>
            </div>
        </nav>
        )
    }
}
export default Menu;