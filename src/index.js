import React from 'react';
import ReactDOM from 'react-dom';
import css from 'file.css';


//gdyby sypa�o b��dami yarn add @babel/plugin-proposal-class-properties --dev /
ReactDOM.render(<div>TEST </div>, document.getElementById("root"));
class Clock extends React.Component {
    constructor(props) {
        super(props);
        this.state = { date: new Date() };
    }

    componentDidMount() {
        this.timerID = setInterval(
            () => this.tick(),
            1000
        );
    }

    componentWillUnmount() {
        clearInterval(this.timerID);
    }

    tick() {
        this.setState({
            date: new Date()
        });
    }


    render() {
        return (

            <div>
                <h1>Clock!</h1>
                <h2>It is {this.state.date.toLocaleTimeString()}.</h2>
            </div>
        );
    }

}

ReactDOM.render(<Clock />, document.getElementById('root'));


class Button extends React.Component {

    state = { counter: 1 };

    handleClick = () => {
        this.setState((prevState) => ({
            counter: prevState.counter + 1
        }));
    };

    render() {
        return (
            <div>
                <h1>button that increment this value--><button onClick={this.handleClick} style={{ backgroundColor: 'yellow' }}>
                    {this.state.counter}
                </button></h1>
            </div>
        );
    }
}

ReactDOM.render(<Button />, document.getElementById('root2'));

class Team extends React.Component {
    constructor(props) {
        super(props);
        this.state = { value: '' };

        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    handleChange(event) {
        this.setState({ value: event.target.value });
    }

    handleSubmit(event) {
        alert('A Team was added: ' + this.state.value);
        event.preventDefault();
    }

    render() {
        return (
            <form onSubmit={this.handleSubmit}>
                <label>
                    Team:
            <input type="text" value={this.state.value} onChange={this.handleChange} />
                </label>
                <input type="submit" value="Submit" />
            </form>
        );
    }
}
ReactDOM.render(<Team />, document.getElementById('root3'));