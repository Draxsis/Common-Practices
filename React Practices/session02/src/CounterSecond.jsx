import React, { Component } from "react";

class CounterSecondary extends Component {
  constructor(props) {
    super(props);
    this.state = {
      count: 0,
    };
  }

  render() {
    return (
      <>
        <div
          style={{ border: "2px solid", margin: "10px 1px", padding: "10px" }}
        >
          <label>{this.props.label} </label>
          <label>{this.props.label2} </label>
          <hr />
          <button style={{ margin: "0px 16px" }} onClick={this.Minus}>
            -
          </button>
          <p1>Count: {this.state.count}</p1>
          <button style={{ margin: "0px 16px" }} onClick={this.Add}>
            +
          </button>
        </div>
      </>
    );
  }

  Add = () => {
    this.setState({
      count: this.state.count < 20 ? this.state.count + 5 : this.state.count,
    });
  };

  Minus = () => {
    this.setState({
      count: this.state.count > 0 ? this.state.count - 5 : this.state.count,
    });
  };
}

export default CounterSecondary;
