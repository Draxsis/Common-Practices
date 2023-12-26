import { Component } from "react";

class Display extends Component {
  constructor(props) {
    super(props);
    this.state = {
      passive: 0,
    };
  }

  handleInputChange = (e) => {
    const inputText = e.target.value;
    const charCount = inputText.length;
    this.setState({ Passive: charCount });
    document.getElementById("Range").value = charCount;
  };

  render() {
    return (
      <>
        <div
          style={{
            border: "1px solid ",
            padding: "10px",
            borderColor: this.props.color,
            width: "60%",
            height: "250px",
          }}
        >
          <label>Write it Down </label>
          <hr></hr>
          <p>
            you can't write more than <span style={{ color: "red" }}>20</span>{" "}
            characters
          </p>
          <input
            type="text"
            maxLength={this.props.maxLength}
            onChange={this.handleInputChange}
          />

          <div>
            <p
              style={{
                position: "relative",
                left: "13%",
                margin: "110px 0px -14% 67%",
                border: "2px solid",
                width: "180px",
                padding: "10px",
              }}
            >
              Number of Characters: {this.state.Passive}
            </p>
            <input
              type="range"
              id="Range"
              min="0"
              max="20"
              value={this.state.Passive}
            />
          </div>
        </div>
      </>
    );
  }
}

export default Display;
