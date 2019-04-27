import React from 'react';

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
export default Button;