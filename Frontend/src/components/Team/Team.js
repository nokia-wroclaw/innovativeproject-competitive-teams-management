import React from 'react';
import MuiThemeProvider from '@material-ui/core/styles/MuiThemeProvider';
import Button from '@material-ui/core/Button';
import TextField from '@material-ui/core/TextField';
// import Label from '@material-ui/core/Label';
class Team extends React.Component {
    constructor(props) {
        super(props);
        this.state = { teamName: "", firstPlayerName: "", firstPlayerLastName: ""};

        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    // handleChange(event) {
    //     this.setState({ value: event.target.value });
    // }

    handleChange(event) {
        const target = event.target;
        const value = event.target.value;
        const name = target.name;
        this.setState({
            [name]: value
        });
    }

    handleSubmit(event) {
        alert('A Team was added: \n\nTeam name: ' + this.state.teamName + '\nFirst player: ' + this.state.firstPlayerName + ' ' + this.state.firstPlayerLastName );
        event.preventDefault();
        // frontend :8080
        // backend :8081
        // const team_data = {this.state.teamName, this.state.firstPlayerName, this.state.firstPlayerLastName}
        // jsonify to coś ^
        // axios.post('http://localhost:8081/new_team', team_data)
        // ^ to zamiast: <form post>


        // a jak wyswietlic to (w innej funkcji) axios.get('http://localhost:8081/get_all_teams')

    }

    render() {
        return (
            <MuiThemeProvider>
                <label>Team info</label>
                <br/>
                <TextField label="Team name" hintText="Team name" name="teamName" onChange={this.handleChange} ></TextField>
                <br/>
                <TextField label="First name" hintText="First name" name="firstPlayerName" onChange={this.handleChange} ></TextField>
                <br/>
                <TextField label="Last name" hintText="Team name" name="firstPlayerLastName" onChange={this.handleChange} ></TextField>
                <br/>
                <br/>
                <Button variant="raised" color="primary" onClick={this.handleSubmit}>Add team</Button>
                <br/>
            </MuiThemeProvider>
        );
    }
}
export default Team;